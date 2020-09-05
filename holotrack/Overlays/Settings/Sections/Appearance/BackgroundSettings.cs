using holotrack.Graphics.Interface;
using holotrack.Graphics.Sprites;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osuTK;

namespace holotrack.Overlays.Settings.Sections.Appearance
{
    public class BackgroundSettings : SettingsSubSection
    {
        public BackgroundSettings()
        {
            HeaderText = @"Background Settings";
            SubHeaderText = @"Customize your scenery";

            Add(new SettingsColorPicker
            {
                Label = @"Background Color",
                Bindable = new Bindable<Colour4>
                {
                    Default = Colour4.Green,
                },
            });

            Add(new FillFlowContainer
            {
                RelativeSizeAxes = Axes.X,
                AutoSizeAxes = Axes.Y,
                Spacing = new Vector2(0, 5),
                Direction = FillDirection.Vertical,
                Children = new Drawable[]
                {
                    new HoloTrackSpriteText
                    {
                        Text = @"Position"
                    },
                    new GridContainer
                    {
                        Height = 25,
                        RelativeSizeAxes = Axes.X,
                        ColumnDimensions = new[]
                        {
                            new Dimension(GridSizeMode.Distributed),
                            new Dimension(GridSizeMode.Distributed),
                        },
                        Content = new[]
                        {
                            new Drawable[]
                            {
                                new SettingsBadgedNumberBox<float>
                                {
                                    Width = 0.75f,
                                    BadgeText = @"X",
                                    Bindable = new BindableFloat(),
                                },
                                new SettingsBadgedNumberBox<float>
                                {
                                    Width = 0.75f,
                                    BadgeText = @"Y",
                                    Bindable = new BindableFloat(),
                                    Anchor = Anchor.TopRight,
                                    Origin = Anchor.TopRight,
                                },
                            },
                        },
                    }
                }
            });

            Add(new SettingsSliderBar<float>
            {
                Label = @"Scale",
                Bindable = new BindableFloat
                {
                    MinValue = 1.0f,
                    MaxValue = 5.0f,
                    Precision = 0.1f,
                    Default = 1.0f,
                    Value = 1.0f,
                }
            });

            Add(new HoloTrackButton
            {
                Text = @"Reset",
                BackgroundColor = Colour4.Red,
                RelativeSizeAxes = Axes.X,
                Action = () => {},
            });
        }
    }
}