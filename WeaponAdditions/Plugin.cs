using System.IO;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using LocalizationManager;
using ServerSync;
using WeaponAdditions.Functions;
using WeaponAdditions.Utils;

namespace WeaponAdditions
{
    [BepInPlugin(modGUID, modName, modVersion)]
    [BepInDependency("blacks7ar.BowPlugin", BepInDependency.DependencyFlags.SoftDependency)]
    
    public class Plugin : BaseUnityPlugin
    {
        private const string modGUID = "blacks7ar.WeaponAdditions";
        public const string modName = "WeaponAdditions";
        public const string modAuthor = "blacks7ar";
        public const string modVersion = "1.1.7";
        public const string modLink = "https://valheim.thunderstore.io/package/blacks7ar/WeaponAdditions/";
        private static string configFileName = modGUID + ".cfg";
        private static string configFileFullPath = Paths.ConfigPath + Path.DirectorySeparatorChar + configFileName;
        public static readonly ManualLogSource WALogger = BepInEx.Logging.Logger.CreateLogSource(modName);
        private static readonly Harmony _harmony = new(modGUID);

        private static readonly ConfigSync _configSync = new(modGUID)
        {
            DisplayName = modName,
            CurrentVersion = modVersion,
            MinimumRequiredVersion = modVersion
        };

        private static ConfigEntry<Toggle> _serverConfigLocked;
        public static bool _IsBowPluginInstalled;

        private ConfigEntry<T> config<T>(string group, string name, T value, ConfigDescription description,
            bool synchronizedConfig = true)
        {
            var configDescription =
                new ConfigDescription(
                    description.Description +
                    (synchronizedConfig ? " [Synced with Server]" : " [Not Synced with Server]"),
                    description.AcceptableValues, description.Tags);
            var configEntry = Config.Bind(group, name, value, configDescription);
            _configSync.AddConfigEntry(configEntry).SynchronizedConfig = synchronizedConfig;
            return configEntry;
        }

        private void ConfigWatcher()
        {
            var watcher = new FileSystemWatcher(Paths.ConfigPath, configFileName);
            watcher.Changed += OnConfigChanged;
            watcher.Created += OnConfigChanged;
            watcher.Renamed += OnConfigChanged;
            watcher.IncludeSubdirectories = true;
            watcher.SynchronizingObject = ThreadingHelper.SynchronizingObject;
            watcher.EnableRaisingEvents = true;
        }

        private void OnConfigChanged(object sender, FileSystemEventArgs e)
        {
            if (!File.Exists(configFileFullPath)) return;
            try
            {
                Logging.LogDebug("OnConfigChanged called..");
                Config.Reload();
            }
            catch
            {
                Logging.LogError($"There was an issue loading your {configFileName}");
                Logging.LogError("Please check your config entries for spelling and format!");
            }
        }
        
        public void Awake()
        {
            Localizer.Load();
            _serverConfigLocked = config("1- ServerSync", "Lock Configuration", Toggle.On,
                new ConfigDescription("If On, the configuration is locked and can be changed by server admins only."));
            _configSync.AddLockingConfigEntry(_serverConfigLocked);
            _IsBowPluginInstalled = Helper.CheckBowPlugin();
            //ConfigSetup.Init();
            PrefabsSetup.Init();
            PrefabsSetup.Effects();
            var assembly = Assembly.GetExecutingAssembly();
            _harmony.PatchAll(assembly);
            ConfigWatcher();
        }

        private void OnDestroy()
        {
            Config.Save();
        }
    }
}