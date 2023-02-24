using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CregForm.Controls;

namespace CregForm.Resources.classes
{
    public static class LSTS
    {
        #region Allgemein

        public static readonly List<string> Arge = new()
        {
            "ARGE", "Ja", "Nein", "Unbekannt"
        };

        public static readonly List<string> Migra = new()
        {
            "Migrationshintergrund", "Ja", "Nein", "Unbekannt"
        };

        public static readonly List<string> Beratung = new()
        {
            "Beratungsart", "SGB VII", "MuKi + allgem. Sgs", "Beratung n. pränatal", "Allgem. LB",
            "RA"
        };

        public static readonly List<string> Anregung = new()
        {
            "Anregung durch", "Schule", "Jugendamt", "Gericht", "Bekannte", "Soz.", "Sonstige", "Unbekannt"
        };

        public static readonly List<string> Anmeldung = new()
        {
            "Anmeldung durch", "Erwachsene*r", "Junger Mensch"
        };

        public static readonly List<string> Grund = new()
        {
            "Abschlussgrund", "Grund 1", "Grund 2"
        };

        #endregion

        #region Ehe und Leben
        public static readonly List<string> EheUndLebenLeistung = new()
        {
            "Art der Leistung", "Eine Person", "Paar", "ARGE", "RA"
        };

        public static readonly List<string> EheUndLebenWirtschaft = new()
        {
            "Wirtschaftlicher Hintergrund", "Ja", "Nein", "Unbekannt"
        };
        #endregion

        #region SGB8

        public static readonly List<string> Sgb8Leistung = new()
        {
            "Art der Leistung", "Mit Familie", "Mit Eltern", "Junge Menschen", "Trennung", "§ 8a", "Fallbesprechung"
        };

        public static readonly List<string> Sgb8Wirtschaft = new()
        {
            "Wirtschaftliche Situation", "Ja", "Nein", "Unbekannt"
        };

        public static readonly List<string> Sgb8Haushalt = new()
        {
            "Herkunftshaushalt", "Eltern zusammen", "Eltern allein", "Eltern neue Partner*in", "Sonstiges", "Unbekannt"
        };

        public static readonly List<string> Sgb8Hilfe = new()
        {
            "Hilfe Nr.", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"
        };

        #endregion

        #region MutterKind

        public static readonly List<string> MuKiStaat = new()
        {
            "Staatsangehörigkeit", "Deutsch", "Andere Länder", "Geflüchtete*r", "Keine Angabe"
        };

        public static readonly List<string> MuKiAntrag = new()
        {
            "Antragsstand", "Kein Antrag", "Antrag nicht bewilligt", "Antrag bewilligt"
        };

        public static readonly List<string> MuKiKommunikation = new()
        {
            "Kommunikation", "Online", "Telefonisch", "Keine Angabe"
        };

        public static readonly List<string> MuKiLebensstand = new()
        {
            "Lebensstand", "Ledig", "Verheiratet", "Verpartnert", "Bei Eltern"
        };

        public static readonly List<string> MuKiErwerb = new()
        {
            "Erwerbstätigkeit", "Voll Erwebstätig", "Teil Erwerbstätig", "Arbeitslos", "Ausschließlich SGII", "Zusätzlich SGII", "Schule oder Sudium", "Sonstige nicht Erwerbstätig", "Sonstige", "Keine Angabe"
        };

        #endregion

        #region P218

        public static readonly List<string> P218Staat = new()
        {
            "Staatsangehörigkeit", "Deutsch", "Andere Länder", "Geflüchtete*r", "Keine Angabe"
        };

        public static readonly List<string> P218Stand = new()
        {
            "Lebensstand", "Ledig", "Verheiratet", "Verpartnert", "Bei Eltern"
        };

        public static readonly List<string> P218Erwerb = new()
        {
            "Erwerbstätigkeit", "Voll Erwebstätig", "Teil Erwerbstätig", "Arbeitslos", "Ausschließlich SGII",
            "Zusätzlich SGII", "Schule oder Sudium", "Sonstige nicht Erwerbstätig", "Sonstige", "Keine Angabe"
        };

        public static readonly List<string> P218Verhütung = new()
        {
            "Art der Verhütung", "Nicht Verhütet", "Medikamentös", "Mech", "Natürlich", "Keine Angabe"
        };

        #endregion

        #region AllgSgs

        public static readonly List<string> AllgSgsStaat = new()
        {
            "Staatsangehörigkeit", "Deutsch", "Andere Länder", "Geflüchtete*r", "Keine Angabe"
        };

        public static readonly List<string> AllgSgsLebensstand = new()
        {
            "Lebensstand", "Ledig", "Verheiratet", "Verpartnert", "Bei Eltern"
        };

        public static readonly List<string> AllgSgsErwerb = new()
        {
            "Erwerbstätigkeit", "Voll Erwebstätig", "Teil Erwerbstätig", "Arbeitslos", "Ausschließlich SGII",
            "Zusätzlich SGII", "Schule oder Sudium", "Sonstige nicht Erwerbstätig", "Sonstige", "Keine Angabe"
        };

        #endregion

        #region ARGE

        public static readonly List<string> ARGE12 = new()
        {
            "I oder II", "I", "II"
        };

        public static readonly List<string> ARGEBelastung = new()
        {
            "Art der Belastung", "Alltag", "Partner", "Herkunft", "Sucht", "Psychische Probleme"
        };

        public static readonly List<string> ARGEBasis = new()
        {
            "Basis", "Kein Verm. hemmnis", "Kunde stabilisiert", "Problem bleibt", "Weitervermittlung", "Weiterleitung", "Anbahnung"
        };

        public static readonly List<string> ARGEAbbruch = new()
        {
            "Basis Abbruch durch", "Kunde", "Beratungsstelle", "durch Sonstige", "Sonstiges"
        };

        public static readonly List<string> ARGEKomplett = new()
        {
            "Komplett", "Kein Psy. hemmnis", "Kunde stabilisiert", "Problem bleibt", "Weitervermittlung", "Weiterleitung",
            "Anbahnung"
        };

        public static readonly List<string> ARGEKomplettAbbruch = new()
        {
            "Komplett Abbruch durch", "Kunde", "Beratungsstelle", "durch Sonstige", "Sonstiges"
        };

        public static readonly List<string> ARGEWochen = new()
        {
            "Wochen", "Bis 4 Wochen", "4-12 Wochen", "Mehr als 12 Wochen"
        };

        #endregion

        #region P2a

        public static readonly List<string> P2aStand = new()
        {
            "Lebensstand", "Ledig", "Verheiratet", "Verpartnert", "Bei Eltern"
        };

        public static readonly List<string> P2aErwerb = new()
        {
            "Erwerbstätigkeit", "Voll Erwebstätig", "Teil Erwerbstätig", "Arbeitslos", "Ausschließlich SGII",
            "Zusätzlich SGII", "Schule oder Sudium", "Sonstige nicht Erwerbstätig", "Sonstige", "Keine Angabe"
        };

        #endregion

        #region Alter

        public static readonly List<string> Personen = new()
        {
            "Erwachsene*r 1", "Erwachsene*r 2", "Kind 1", "Kind 2", "Kind 3", "Kind 4", "Kind 5"
        };

        #endregion

        #region Suche

        public static readonly List<string> Tabellen = new()
        {
            "Allgemein", "Ehe und Leben", "SGB VIII", "Mutter & Kind", "§ 218", "Allg. Schwgs.", "ARGE", "§ 2a"
        };

        #endregion
    }

    public static class DICT
    {
        public static Dictionary<string, string> Allgemein { get; set; } = new();
        public static Dictionary<string, string> EheUndLeben { get; set; } = new();
    }

    public static class DSTR
    {
        public static void StoreTextBoxContent(Control frame, Dictionary<string, string> dictionary)
        {
            foreach (Control control in frame.Controls)
            {
                if (control is not CustomControls.RJControls.RJTextBox textBox || textBox.Texts == "") continue;

                dictionary.Add(textBox.Name[2..], textBox.Texts);
            }
        }

        public static void StoreDropDownContent(Control frame, Dictionary<string, string> dictionary)
        {
            foreach (Control item in frame.Controls)
            {
                if (!item.Enabled || item is not DropDown) continue;

                var dd = (DropDown)item;
                var key = dd.Items[0].ToString();
                var value = dd.Texts;

                if (key != null && key != value) dictionary.Add(key, value);
            }
        }

        public static void StoreToggleContent(Control frame, Dictionary<string, string> dictionary)
        {
            foreach (Control item in frame.Controls)
            {
                if (item is not RJToggleButton) continue;

                var tb = (RJToggleButton)item;
                var key = tb.Name[6..];
                var value = tb.Checked switch
                {
                    true => "Ja",
                    false => "Nein"
                };

                switch (key)
                {
                    case "Grund" when tb.Checked:
                    case "Sonstige" when !tb.Checked:
                    case "Unbekannt" when !tb.Checked:
                        continue;
                    case "Wartezeit" when tb.Checked:
                        dictionary.Add("Wartezeit", "Länger als 4 Wochen");
                        break;
                    case "Wartezeit" when !tb.Checked:
                        dictionary.Add("Wartezeit", "Bis zu 4 Wochen");
                        break;
                    default:
                        dictionary.Add(key, value);
                        break;
                }
            }
        }

        public static void StoreAlterGridContent(Control frame, Dictionary<string, string> dictionary)
        {
            foreach (var control in frame.Controls)
            {
                if (control is not DataGridView) continue;

                var grid = (DataGridView)control;

                foreach (DataGridViewRow row in grid.Rows)
                {
                    var key = row.Cells[0].Value.ToString();
                    var value = row.Cells[1].Value?.ToString() ??
                                row.Cells[2].Value?.ToString() ?? row.Cells[3].Value?.ToString();

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null || cell.ColumnIndex == 0) continue;

                        switch (cell.ColumnIndex)
                        {
                            case 1:
                                value += " m";
                                break;
                            case 2:
                                value += " w";
                                break;
                            case 3:
                                value += " nb";
                                break;
                        }
                    }
                    if (value != null) dictionary.Add(key, value);
                }
            }
        }

        public static void StoreCheckBoxContent(Control frame, Dictionary<string, string> dictionary)
        {
            StringBuilder checkedBoxes = new();
            var group = (GroupBox)frame;
            foreach (Control control in frame.Controls)
            {
                switch (control)
                {
                    case CheckBox { Checked: false }:
                        continue;
                    case CheckBox cb:
                        checkedBoxes.AppendLine(cb.Text);
                        break;
                }
            }
            if (checkedBoxes.Length > 2)
                checkedBoxes.Length -= 2;
            dictionary.Add(group.Text, checkedBoxes.ToString());
        }

        public static void StoreStundenGridContent(Control frame, Dictionary<string, string> dictionary)
        {
            foreach (var control in frame.Controls)
            {
                if (control is not DataGridView grid) continue;

                var value = new StringBuilder();

                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.Cells[1].Value == null) continue;

                    var _key = row.Cells[0].Value.ToString();
                    var _value = row.Cells[1].Value.ToString();

                    value.AppendLine(_key + ": " + _value);
                }

                dictionary.Add("Stunden", value.ToString());
            }
        }

        public static void ValidateEntries(Dictionary<string, string> dictionary)
        {
            DataGridView grid = new()
            {
                AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
                RowHeadersVisible = false,
                AutoSize = true
            };
            grid.Columns.Add("Key", "Schlüssel");
            grid.Columns.Add("Value", "Wert");
            grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;




            foreach (var pair in dictionary)
            {
                grid.Rows.Add(pair.Key, pair.Value);
            }

            Form presenter = new()
            {
                AutoSize = true,
                Name = "Presenter",
                FormBorderStyle = FormBorderStyle.FixedSingle
            };
            presenter.Controls.Add(grid);
            grid.Dock = DockStyle.Fill;

            presenter.ShowDialog();
        }
    }
}



