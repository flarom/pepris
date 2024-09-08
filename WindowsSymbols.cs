using System.Drawing.Drawing2D;

namespace Pepris {
    internal class WindowsSymbols {
        private readonly Dictionary<string, char> symbols;
        private readonly string fontName;

        public WindowsSymbols() {
            var version = Environment.OSVersion.Version;

            symbols = new Dictionary<string, char> {
                // Navigation
                { "check",    '\uE10B' },
                { "xmark",    '\uE106' },
                { "back",     '\uE0A6' },
                { "forward",  '\uE0AB' },
                { "open",     '\uE143' },
                { "home",     '\uE80F' },
                { "refresh",  '\ue72c' },
                { "settings", '\uE713' },
            
                // CRUD and File Management
                { "search",   '\uE094' },
                { "save",     '\uE105' },
                { "delete",   '\uE107' },
                { "add",      '\uE109' },
                { "remove",   '\uE108' },
                { "edit",     '\uE104' },
                { "pin",      '\uE141' },
                { "unpin",    '\uE196' },
                { "cut",      '\uE16B' },
                { "copy",     '\uE16F' },
                { "paste",    '\uE16D' },
                { "filter",   '\uE16E' },
                { "attach",   '\uE16C' },
                { "upload",   '\ue898' },
                { "download", '\ue896' },
                { "folderOpen", '\ued25' },
                { "rename",   '\ue8ac' },
            
                // File Formats
                { "file",     '\uE130' },
                { "folder",   '\uE8B7' },
                { "image",    '\ue91b' },
                { "video",    '\uE714' },
                { "link",     '\uE71B' },
                { "pdf",      '\uea90' },
                { "doc",      '\uf000' },
                { "zip",      '\uf012' },
            
                // Social
                { "person",   '\uE13D' },
                { "people",   '\uE125' },
                { "report",   '\uE129' },
                { "like",     '\uE006' },
                { "liked",    '\uE00B' },
                { "unlike",   '\uE00C' },
                { "dm",       '\uE122' },
                { "emote",    '\uE11D' },
                { "share",    '\uE72D' },
                { "mention",  '\ue168' },
                { "follow",   '\ue8fa' },
                { "block",    '\ue8f8' },
            
                // Media Control
                { "play",     '\uE768' },
                { "pause",    '\uE769' },
                { "stop",     '\ue71a' },
                { "next",     '\ue893' },
                { "prev",     '\ue892' },
                { "volume",   '\uE767' },
                { "mute",     '\ue74f' },
                { "shuffle",  '\ue8b1' },
                { "repeat",   '\ue8ee' },
            
                // Interaction
                { "accessibility", '\uE776' },
                { "customize",     '\uE771' },
                { "list",          '\uE8FD' },
                { "power",         '\uE7E8' },
                { "more",          '\ue712' },
                { "help",          '\ue897' },
                { "info",          '\ue946' },
                { "error",         '\uea39' },
                { "warning",       '\ue7ba' },
            
                // Objects
                { "clock",        '\uE121' },
                { "speedometer",  '\uec4a' },
                { "battery",      '\ue855' },
                { "wifi",         '\ue701' },
                { "bluetooth",    '\ue702' },
                { "location",     '\uE81D' },
                { "calendar",     '\ue787' },
                { "camera",       '\ue722' },
                { "microphone",   '\uE1D6' },
                { "calculator",   '\ue8ef' },
                { "weather",      '\ue753' },
                { "flashlight",   '\ue754' },
                { "globe",        '\ue774' },
                { "layers",       '\uf156' },
                { "pyramid",      '\uf157' },
                { "cube",         '\uf158' },
                { "octahedron",   '\uf159' },
            };

            if (version.Major == 10 && version.Build >= 22000) {
                fontName = "Segoe Fluent Icons";  // Windows 11
            }
            else if (version.Major == 10) {
                fontName = "Segoe MDL2 Assets";  // Windows 10
            }
            else {
                fontName = "Segoe UI Symbol";  // Windows 7/8/8.1
            }
        }
        public void ApplySymbol(string symbolName, Control control, float fontSize = 12) {
            if (symbols.TryGetValue(symbolName, out char symbol)) {
                control.Text = symbol.ToString();
            }
            else {
                control.Text = "?";
            }
            control.Font = new Font(fontName, fontSize);
        }
        public void ApplySymbol(char symbol, Control control, float fontSize = 12) {
            control.Text = symbol.ToString();
            control.Font = new Font(fontName, fontSize);
        }
        public Image GetSymbolAsImage(string symbolName, Color color, int size) {
            if (symbols.TryGetValue(symbolName, out char symbol)) {
                Bitmap bitmap = new Bitmap(size, size);
                using (Graphics g = Graphics.FromImage(bitmap)) {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                    g.Clear(Color.Transparent);

                    using (Font iconFont = new Font(fontName, size - 2, FontStyle.Regular, GraphicsUnit.Pixel)) {
                        using (Brush brush = new SolidBrush(color)) {
                            SizeF textSize = g.MeasureString(symbol.ToString(), iconFont);
                            float x = (size - textSize.Width) / 2;
                            float y = (size - textSize.Height) / 2;
                            g.DrawString(symbol.ToString(), iconFont, brush, x, y);
                        }
                    }
                }
                return bitmap;
            }
            else {
                throw new ArgumentException($"Símbolo '{symbolName}' não encontrado.");
            }
        }
        public Image GetSymbolAsImage(char symbol, Color color, int size) {
            Bitmap bitmap = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bitmap)) {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                g.Clear(Color.Transparent);

                using (Font iconFont = new Font(fontName, size - 2, FontStyle.Regular, GraphicsUnit.Pixel)) {
                    using (Brush brush = new SolidBrush(color)) {
                        SizeF textSize = g.MeasureString(symbol.ToString(), iconFont);
                        float x = (size - textSize.Width) / 2;
                        float y = (size - textSize.Height) / 2;
                        g.DrawString(symbol.ToString(), iconFont, brush, x, y);
                    }
                }
            }
            return bitmap;
        }

        public char GetSymbol(string symbolName) {
            return symbols.TryGetValue(symbolName, out char symbol) ? symbol : '?';
        }

        public string GetRecommendedFont() {
            return fontName;
        }
        public Image TintImage(Image originalImage, Color tintColor) {
            Bitmap originalBitmap = new Bitmap(originalImage);

            Bitmap tintedBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            for (int y = 0; y < originalBitmap.Height; y++) {
                for (int x = 0; x < originalBitmap.Width; x++) {
                    Color originalColor = originalBitmap.GetPixel(x, y);

                    if (originalColor.A == 0) {
                        tintedBitmap.SetPixel(x, y, Color.Transparent);
                    }
                    else {
                        int r = (tintColor.R * originalColor.R) / 255;
                        int g = (tintColor.G * originalColor.G) / 255;
                        int b = (tintColor.B * originalColor.B) / 255;
                        Color tintedColor = Color.FromArgb(originalColor.A, r, g, b);

                        tintedBitmap.SetPixel(x, y, tintedColor);
                    }
                }
            }

            return tintedBitmap;
        }


        public void ShowZoo() {
            Form form = new Form {
                Text = "Icon Zoo",
                Size = new Size(400, 600)
            };
            ColumnHeader colName = new ColumnHeader {
                Text = "Symbol Name",
                Width = 200
            };
            ColumnHeader colChar = new ColumnHeader {
                Text = "Character",
                Width = 100
            };

            ListView listView = new ListView {
                Font = new Font(GetRecommendedFont(), 12f),
                Dock = DockStyle.Fill,
                View = View.Details,
                FullRowSelect = true
            };
            listView.Columns.AddRange(new ColumnHeader[] { colName, colChar });

            foreach (KeyValuePair<string, char> symbol in symbols) {
                ListViewItem item = new ListViewItem(symbol.Key);
                item.SubItems.Add(symbol.Value.ToString());
                listView.Items.Add(item);
            }

            form.Controls.Add(listView);
            form.ShowDialog();
        }

    }
}
