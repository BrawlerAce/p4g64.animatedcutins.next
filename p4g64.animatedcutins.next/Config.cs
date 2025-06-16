using p4g64.animatedcutins.next.Template.Configuration;
using Reloaded.Mod.Interfaces.Structs;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace p4g64.animatedcutins.next.Configuration
{
    public class Config : Configurable<Config>
    {
        /*
            User Properties:
                - Please put all of your configurable properties here.
    
            By default, configuration saves as "Config.json" in mod user config folder.    
            Need more config files/classes? See Configuration.cs
    
            Available Attributes:
            - Category
            - DisplayName
            - Description
            - DefaultValue

            // Technically Supported but not Useful
            - Browsable
            - Localizable

            The `DefaultValue` attribute is used as part of the `Reset` button in Reloaded-Launcher.
        */

        // Cut-in Style
        public enum Appearance
        {
            [Display(Name = "P4A Style")]
            P4A,
            [Display(Name = "P4G Style")]
            P4G,
        }

        [Category("Appearance")]
        [DisplayName("Cut-in Style")]
        [Description("Choose a cut-in style.\n\nP4G Style: Shorter, smaller cut-ins similarly sized to the base game's cut-ins.\n\nP4A Style: Taller, larger cut-ins that are more faithful to the anime.")]
        [DefaultValue(Appearance.P4A)]
        public Appearance AppearanceConfig { get; set; } = Appearance.P4A;

        // Character Toggles
        [Category("Character Toggle")]
        [DisplayName("Protagonist")]
        [Description("Toggles animated cut-ins for the given character.")]
        [DefaultValue(true)]
        public bool ProtagEnabled { get; set; } = true;

        [Category("Character Toggle")]
        [DisplayName("Yosuke")]
        [Description("Toggles animated cut-ins for the given character.")]
        [DefaultValue(true)]
        public bool YosukeEnabled { get; set; } = true;

        [Category("Character Toggle")]
        [DisplayName("Chie")]
        [Description("Toggles animated cut-ins for the given character.")]
        [DefaultValue(true)]
        public bool ChieEnabled { get; set; } = true;

        [Category("Character Toggle")]
        [DisplayName("Yukiko")]
        [Description("Toggles animated cut-ins for the given character.")]
        [DefaultValue(true)]
        public bool YukikoEnabled { get; set; } = true;

        [Category("Character Toggle")]
        [DisplayName("Kanji")]
        [Description("Toggles animated cut-ins for the given character.")]
        [DefaultValue(true)]
        public bool KanjiEnabled { get; set; } = true;

        [Category("Character Toggle")]
        [DisplayName("Rise")]
        [Description("Toggles animated cut-ins for the given character.")]
        [DefaultValue(true)]
        public bool RiseEnabled { get; set; } = true;

        [Category("Character Toggle")]
        [DisplayName("Teddie")]
        [Description("Toggles animated cut-ins for the given character.")]
        [DefaultValue(true)]
        public bool TeddieEnabled { get; set; } = true;

        [Category("Character Toggle")]
        [DisplayName("Naoto")]
        [Description("Toggles animated cut-ins for the given character.")]
        [DefaultValue(true)]
        public bool NaotoEnabled { get; set; } = true;

        [Category("Character Toggle")]
        [DisplayName("Culprit")]
        [Description("Toggles animated cut-ins for the given character.")]
        [DefaultValue(true)]
        public bool CulpritEnabled { get; set; } = true;

    }

    /// <summary>
    /// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
    /// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
    /// </summary>
    public class ConfiguratorMixin : ConfiguratorMixinBase
    {
        // 
    }
}
