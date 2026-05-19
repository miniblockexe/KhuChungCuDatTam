using System;
using System.Drawing;

namespace KhuChungCuDatTam
{
    public enum ThemeMode { Dark, Light }

    public class ThemePalette
    {
        public Color Background { get; set; }
        public Color Sidebar { get; set; }
        public Color Card { get; set; }
        public Color Header { get; set; }
        public Color Input { get; set; }
        public Color TextPrimary { get; set; }
        public Color TextMuted { get; set; }
        public Color TextLabel { get; set; }
        public Color Primary { get; set; }
        public Color Success { get; set; }
        public Color Danger { get; set; }
        public Color Warning { get; set; }
        public Color Border { get; set; }
        public Color GridAltRow { get; set; }
        public Color GridHeader { get; set; }
        public Color Toolbar { get; set; }
        public Color SidebarHover { get; set; }
        public Color ButtonMuted { get; set; }
    }

    public static class AppTheme
    {
        public static event EventHandler ThemeChanged;

        private static ThemeMode _mode = ThemeMode.Dark;

        public static ThemeMode Mode => _mode;
        public static bool IsDark => _mode == ThemeMode.Dark;
        public static bool IsLight => _mode == ThemeMode.Light;

        public static ThemePalette Current => IsDark ? Dark : Light;

        public static readonly ThemePalette Dark = new ThemePalette
        {
            Background = Color.FromArgb(15, 23, 42),   
            Sidebar = Color.FromArgb(17, 24, 39),  
            Card = Color.FromArgb(30, 41, 59),   
            Header = Color.FromArgb(17, 24, 39),
            Input = Color.FromArgb(15, 23, 42),
            TextPrimary = Color.White,
            TextMuted = Color.FromArgb(148, 163, 184),  
            TextLabel = Color.FromArgb(148, 163, 184),
            Primary = Color.FromArgb(59, 130, 246),  
            Success = Color.FromArgb(16, 185, 129),
            Danger = Color.FromArgb(239, 68, 68),
            Warning = Color.FromArgb(245, 158, 11),
            Border = Color.FromArgb(30, 41, 59),
            GridAltRow = Color.FromArgb(20, 30, 50),
            GridHeader = Color.FromArgb(15, 23, 42),
            Toolbar = Color.FromArgb(15, 23, 42),
            SidebarHover = Color.FromArgb(30, 41, 59),
            ButtonMuted = Color.FromArgb(100, 116, 139),
        };

        public static readonly ThemePalette Light = new ThemePalette
        {
            Background = Color.FromArgb(218, 225, 238),

            Sidebar = Color.FromArgb(245, 247, 252),

            Card = Color.FromArgb(255, 255, 255),

            Header = Color.FromArgb(245, 247, 252),

            Input = Color.FromArgb(238, 242, 248),

            TextPrimary = Color.FromArgb(15, 30, 55),

            TextMuted = Color.FromArgb(75, 92, 115),

            TextLabel = Color.FromArgb(45, 60, 80),

            Primary = Color.FromArgb(59, 130, 246),
            Success = Color.FromArgb(16, 185, 129),
            Danger = Color.FromArgb(239, 68, 68),
            Warning = Color.FromArgb(245, 158, 11),

            Border = Color.FromArgb(200, 210, 225),

            GridAltRow = Color.FromArgb(232, 238, 248),

            GridHeader = Color.FromArgb(218, 225, 238),

            Toolbar = Color.FromArgb(232, 238, 248),

            SidebarHover = Color.FromArgb(225, 232, 245),

            ButtonMuted = Color.FromArgb(120, 140, 165),
        };


        public static void Toggle()
        {
            _mode = IsDark ? ThemeMode.Light : ThemeMode.Dark;
            ThemeChanged?.Invoke(null, EventArgs.Empty);
        }

        public static void Set(ThemeMode mode)
        {
            if (_mode == mode) return;
            _mode = mode;
            ThemeChanged?.Invoke(null, EventArgs.Empty);
        }
    }
}