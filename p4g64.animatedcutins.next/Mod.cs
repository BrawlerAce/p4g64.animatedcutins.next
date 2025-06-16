using CriFs.V2.Hook.Interfaces;
using p4g64.animatedcutins.next.Configuration;
using p4g64.animatedcutins.next.Template;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;

namespace p4g64.animatedcutins.next
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public class Mod : ModBase // <= Do not Remove.
    {
        /// <summary>
        /// Provides access to the mod loader API.
        /// </summary>
        private readonly IModLoader _modLoader;

        /// <summary>
        /// Provides access to the Reloaded.Hooks API.
        /// </summary>
        /// <remarks>This is null if you remove dependency on Reloaded.SharedLib.Hooks in your mod.</remarks>
        private readonly IReloadedHooks? _hooks;

        /// <summary>
        /// Provides access to the Reloaded logger.
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Entry point into the mod, instance that created this class.
        /// </summary>
        private readonly IMod _owner;

        /// <summary>
        /// Provides access to this mod's configuration.
        /// </summary>
        private Config _configuration;

        /// <summary>
        /// The configuration of the currently executing mod.
        /// </summary>
        private readonly IModConfig _modConfig;

        public Mod(ModContext context)
        {
            _modLoader = context.ModLoader;
            _hooks = context.Hooks;
            _logger = context.Logger;
            _owner = context.Owner;
            _configuration = context.Configuration;
            _modConfig = context.ModConfig;


            // For more information about this template, please see
            // https://reloaded-project.github.io/Reloaded-II/ModTemplate/

            // If you want to implement e.g. unload support in your mod,
            // and some other neat features, override the methods in ModBase.

            // TODO: Implement some mod logic

            var criFsController = _modLoader.GetController<ICriFsRedirectorApi>();
            if (criFsController == null || !criFsController.TryGetTarget(out var criFsApi))
            {
                _logger.WriteLine($"criFSController returned as null! p4g64.animatedcutins.next won't work properly :(", System.Drawing.Color.Red);
                return;
            }

            if (_configuration.AppearanceConfig == Config.Appearance.P4A)
            {
                if (_configuration.ProtagEnabled)
                {
                    criFsApi.AddProbingPath("P4A/Protag");
                }
                if (_configuration.YosukeEnabled)
                {
                    criFsApi.AddProbingPath("P4A/Yosuke");
                }
                if (_configuration.ChieEnabled)
                {
                    criFsApi.AddProbingPath("P4A/Chie");
                }
                if (_configuration.YukikoEnabled)
                {
                    criFsApi.AddProbingPath("P4A/Yukiko");
                }
                if (_configuration.KanjiEnabled)
                {
                    criFsApi.AddProbingPath("P4A/Kanji");
                }
                if (_configuration.RiseEnabled)
                {
                    criFsApi.AddProbingPath("P4A/Rise");
                }
                if (_configuration.TeddieEnabled)
                {
                    criFsApi.AddProbingPath("P4A/Teddie");
                }
                if (_configuration.NaotoEnabled)
                {
                    criFsApi.AddProbingPath("P4A/Naoto");
                }
                if (_configuration.CulpritEnabled)
                {
                    criFsApi.AddProbingPath("P4A/Culprit");
                }
            }

            if (_configuration.AppearanceConfig == Config.Appearance.P4G)
            {
                if (_configuration.ProtagEnabled)
                {
                    criFsApi.AddProbingPath("P4G/Protag");
                }
                if (_configuration.YosukeEnabled)
                {
                    criFsApi.AddProbingPath("P4G/Yosuke");
                }
                if (_configuration.ChieEnabled)
                {
                    criFsApi.AddProbingPath("P4G/Chie");
                }
                if (_configuration.YukikoEnabled)
                {
                    criFsApi.AddProbingPath("P4G/Yukiko");
                }
                if (_configuration.KanjiEnabled)
                {
                    criFsApi.AddProbingPath("P4G/Kanji");
                }
                if (_configuration.RiseEnabled)
                {
                    criFsApi.AddProbingPath("P4G/Rise");
                }
                if (_configuration.TeddieEnabled)
                {
                    criFsApi.AddProbingPath("P4G/Teddie");
                }
                if (_configuration.NaotoEnabled)
                {
                    criFsApi.AddProbingPath("P4G/Naoto");
                }
                if (_configuration.CulpritEnabled)
                {
                    criFsApi.AddProbingPath("P4G/Culprit");
                }
            }


            if ((_configuration.YosukeEnabled == true) && (_configuration.TeddieEnabled == true))
            {
                criFsApi.AddProbingPath("Union/JunesBomber/BothEnabled");
            }

            else if ((_configuration.YosukeEnabled == true) && (_configuration.TeddieEnabled == false))
            {
                criFsApi.AddProbingPath("Union/JunesBomber/YosukeEnabled");
            }

            else if ((_configuration.YosukeEnabled == false) && (_configuration.TeddieEnabled == true))
            {
                criFsApi.AddProbingPath("Union/JunesBomber/TeddieEnabled");
            }


            if ((_configuration.ChieEnabled == true) && (_configuration.YukikoEnabled == true))
            {
                criFsApi.AddProbingPath("Union/TwinDragons/BothEnabled");
            }

            else if ((_configuration.ChieEnabled == true) && (_configuration.YukikoEnabled == false))
            {
                criFsApi.AddProbingPath("Union/TwinDragons/ChieEnabled");
            }

            else if ((_configuration.ChieEnabled == false) && (_configuration.YukikoEnabled == true))
            {
                criFsApi.AddProbingPath("Union/TwinDragons/YukikoEnabled");
            }


            if ((_configuration.NaotoEnabled == true) && (_configuration.KanjiEnabled == true))
            {
                criFsApi.AddProbingPath("Union/BeautyAndTheBeast/BothEnabled");
            }

            else if ((_configuration.NaotoEnabled == true) && (_configuration.KanjiEnabled == false))
            {
                criFsApi.AddProbingPath("Union/BeautyAndTheBeast/NaotoEnabled");
            }

            else if ((_configuration.NaotoEnabled == false) && (_configuration.KanjiEnabled == true))
            {
                criFsApi.AddProbingPath("Union/BeautyAndTheBeast/KanjiEnabled");
            }
        }

        #region Standard Overrides
        public override void ConfigurationUpdated(Config configuration)
        {
            // Apply settings from configuration.
            // ... your code here.
            _configuration = configuration;
            _logger.WriteLine($"[{_modConfig.ModId}] Config Updated: Applying");
        }
        #endregion

        #region For Exports, Serialization etc.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Mod() { }
#pragma warning restore CS8618
        #endregion
    }
}