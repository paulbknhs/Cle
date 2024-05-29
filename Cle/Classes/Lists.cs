namespace Cle.Classes;

public static class Lists
{
    public static readonly List<string> Migra = new()
    {
        "Migra", "Ja", "Nein", "Unbekannt"
    };

    public static readonly List<string> Beratung = new()
    {
        "Beratungsart", "Allgem. LB", "SGB VIII", "MuKi + allgem. Sgs", "Beratung n. pränatal",
        "RA"
    };

    public static readonly List<string> Anregung = new()
    {
        "Anregung", "Schule", "Jugendamt", "Gericht", "Bekannte", "Soz.", "Ärztlich", "Sonstige", "Unbekannt"
    };

    public static readonly List<string> Grund = new()
    {
        "Grund", "1", "2", "3", "4", "5"
    };

    public static readonly List<string> EheUndLebenLeistung = new()
    {
        "Leistung", "Eine Person", "Paar", "ARGE", "RA"
    };

    public static readonly List<string> EheUndLebenWirtschaft = new()
    {
        "Wirtschaftlicher Hintergrund", "Ja", "Nein", "Unbekannt"
    };

    public static readonly List<string> Sgb8Leistung = new()
    {
        "Leistung", "Mit Familie", "Mit Eltern", "Junge Menschen", "Trennung", "§ 8a", "Fallbesprechung"
    };

    public static readonly List<string> Sgb8Anmeldung = new()
    {
        "Anmeldung", "Erwachsene*r", "Junger Mensch"
    };

    public static readonly List<string> Sgb8Wirtschaft = new()
    {
        "Wirtschaftliche Situation", "Bezieht Leistungen", "Bezieht keine Leistungen", "Unbekannt"
    };

    public static readonly List<string> Sgb8Haushalt = new()
    {
        "Herkunftshaushalt", "Eltern zusammen", "Eltern allein", "Eltern neue Partner*in", "Sonstiges", "Unbekannt"
    };

    public static readonly List<string> Sgb8Hilfe = new()
    {
        "Hilfe", "1. Unversorgtheit", "2. Unzrr. Förderung", "3. Gfrd d. Kineswohls", "4. Engsr. Kompetenz",
        "5. Blstg. d. Eltern", "6. Blstg. d. Familie", "7. Sz.Vh. auffällig", "8. seelische Prbl.",
        "9. Schulisch/ Beruf", "10. Andere"
    };

    public static readonly List<string> Sgb8Gender = new()
    {
        "Geschlecht", "Männlich", "Weiblich", "Non-Binary"
    };

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
        "Kommunikation", "Online", "Telefonisch", "Persönlich"
    };

    public static readonly List<string> MuKiLebensstand = new()
    {
        "Lebensstand", "Ledig o. Kinder", "Ledig m. Kinder", "Verheiratet o. Kinder", "Verheiratet m. Kinder",
        "Verpartnert o. Kinder", "Verpartnert m. Kinder", "Bei Eltern o. Kinder", "Bei Eltern m. Kinder"
    };

    public static readonly List<string> MuKiErwerb = new()
    {
        "Erwerbstätigkeit", "Voll Erwebstätig", "Teil Erwerbstätig", "Arbeitslos", "Ausschließlich SGII",
        "Zusätzlich SGII", "Schule oder Sudium", "Sonstige nicht Erwerbstätig", "Sonstige", "Keine Angabe"
    };

    public static readonly List<string> P218Kommunikation = new()
    {
        "Kommunikation", "Online", "Telefonisch", "Persönlich"
    };

    public static readonly List<string> P218Staat = new()
    {
        "Staatsangehörigkeit", "Deutsch", "Andere Länder", "Geflüchtete*r", "Keine Angabe"
    };

    public static readonly List<string> P218Stand = new()
    {
        "Lebensstand", "Ledig o. Kinder", "Ledig m. Kinder", "Verheiratet o. Kinder", "Verheiratet m. Kinder",
        "Verpartnert o. Kinder", "Verpartnert m. Kinder", "Bei Eltern o. Kinder", "Bei Eltern m. Kinder"
    };

    public static readonly List<string> P218Erwerb = new()
    {
        "Erwerbstätigkeit", "Voll Erwebstätig", "Teil Erwerbstätig", "Arbeitslos", "Ausschließlich SGII",
        "Zusätzlich SGII", "Schule oder Sudium", "Sonstige nicht Erwerbstätig", "Sonstige", "Keine Angabe"
    };

    public static readonly List<string> P218Verhütung = new()
    {
        "Verhütung", "Nicht verhütet#", "Medikamentös", "Mechanisch", "Natürlich", "keine Angabe"
    };

    public static readonly List<string> P218Geschlecht = new()
    {
        "Geschlecht", "Weiblich", "Männlich", "Nicht-Binär"
    };

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
        "Basis Status", "Kein Verm. hemmnis", "Kunde stabilisiert", "Problem bleibt", "Weitervermittlung",
        "Weiterleitung", "Anbahnung"
    };

    public static readonly List<string> ARGEAbbruch = new()
    {
        "Basis Abbruch durch", "Kunde", "Beratungsstelle", "durch Sonstige", "Sonstiges"
    };

    public static readonly List<string> ARGEKomplett = new()
    {
        "Komplett Status", "Kein Psy. hemmnis", "Kunde stabilisiert", "Problem bleibt", "Weitervermittlung",
        "Weiterleitung",
        "Anbahnung"
    };

    public static readonly List<string> ARGEKomplettAbbruch = new()
    {
        "Komplett Abbruch durch", "Kunde", "Beratungsstelle", "durch Sonstige", "Sonstiges"
    };

    public static readonly List<string> ARGEWochen = new()
    {
        "Wartezeit", "Bis 4 Wochen", "4-12 Wochen", "Mehr als 12 Wochen"
    };

    public static readonly List<string> P2aStand = new()
    {
        "Lebensstand", "Ledig", "Verheiratet", "Verpartnert", "Bei Eltern"
    };

    public static readonly List<string> P2aErwerb = new()
    {
        "Erwerbstätigkeit", "Voll Erwebstätig", "Teil Erwerbstätig", "Arbeitslos", "Ausschließlich SGII",
        "Zusätzlich SGII", "Schule oder Sudium", "Sonstige nicht Erwerbstätig", "Sonstige", "Keine Angabe"
    };

    public static readonly List<string> Personen = new()
    {
        "Erwachsene*r 1", "Erwachsene*r 2", "Kind 1", "Kind 2", "Kind 3", "Kind 4", "Kind 5"
    };

    public static readonly List<string> Tabellen = new()
    {
        "Allgemein", "Ehe und Leben", "SGB VIII", "Mutter Kind", "§ 218", "Allgemeine Schwangerschaft", "ARGE", "§ 2a"
    };

    public static List<string> Wochentage = new()
    {
        "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag"
    };

    public static List<string> Comparators = new()
    {
        "ist genau", "ist nicht", "Wert ist kleiner als", "Wert ist größer als"
    };
}