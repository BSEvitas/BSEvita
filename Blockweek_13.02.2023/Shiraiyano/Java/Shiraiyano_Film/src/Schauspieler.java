import java.util.ArrayList;
import java.util.List;

class Schauspieler
{
    private String Vorname;
    private String Nachname;
    private String Spitzname;
    private String Geburtsort;
    private String Geburtsdatum;
    private String Nationalitaet;
    private double Groesse; //in Meter

    public Schauspieler(String vorname, String nachname) {
        Vorname = vorname;
        Nachname = nachname;
        Spitzname = "";
        Geburtsort = "";
        Geburtsdatum = "";
        Nationalitaet = "";
        Groesse = 0;
    }

    public Schauspieler(String vorname, String nachname, String spitzname, double groesse) {
        Vorname = vorname;
        Nachname = nachname;
        Spitzname = spitzname;
        Geburtsort = "";
        Geburtsdatum = "";
        Nationalitaet = "";
        Groesse = groesse;
    }

    public Schauspieler(String vorname, String nachname, String spitzname, String geburtsort, String geburtsdatum, String nationalitaet, double groesse) {
        Vorname = vorname;
        Nachname = nachname;
        Spitzname = spitzname;
        Geburtsort = geburtsort;
        Geburtsdatum = geburtsdatum;
        Nationalitaet = nationalitaet;
        Groesse = groesse;
    }

    public Schauspieler() {
        Vorname = "";
        Nachname = "";
        Spitzname = "";
        Geburtsort = "";
        Geburtsdatum = "";
        Nationalitaet = "";
        Groesse = 0;
    }

    public String get_Vorname() {
        return Vorname;
    }
    public void set_Vorname(String vorname) {
        Vorname = vorname;
    }

    public String get_Nachname() {
        return Nachname;
    }
    public void set_Nachname(String nachname) {
        Nachname = nachname;
    }

    public String get_Spitzname() {
        return Spitzname;
    }
    public void set_Spitzname(String spitzname) {
        Spitzname = spitzname;
    }

    public String get_Geburtsort() {
        return Geburtsort;
    }
    public void set_Geburtsort(String geburtsort) {
        Geburtsort = geburtsort;
    }

    public String get_Geburtsdatum() {
        return Geburtsdatum;
    }
    public void set_Geburtsdatum(String geburtsdatum) {
        Geburtsdatum = geburtsdatum;
    }

    public String get_Nationalitaet() {
        return Nationalitaet;
    }
    public void set_Nationalitaet(String nationalitaet) {
        Nationalitaet = nationalitaet;
    }

    public double get_Groesse() {
        return Groesse;
    }
    public void set_Groesse(double groesse) {
        Groesse = groesse;
    }
}
/*
*
* Changed public class Film to class Film because of Errors
*
* */
class Film
{
    private String Titel;
    private int Erscheinungsjahr;
    private String Genre;
    private int Laufzeit; //in ganzen Minuten
    private List<Schauspieler> Cast; //Schauspieler
    private String Sprache;
    private int FSK;

    public Film(String titel, int erscheinungsjahr) {
        Titel = titel;
        Erscheinungsjahr = erscheinungsjahr;
        Genre = "";
        Laufzeit = 0;
        Cast = new ArrayList<Schauspieler>();
        Sprache = "";
        FSK = 0;
    }

    public Film(String titel, int erscheinungsjahr, String genre, int laufzeit) {
        Titel = titel;
        Erscheinungsjahr = erscheinungsjahr;
        Genre = genre;
        Laufzeit = laufzeit;
        Cast = new ArrayList<Schauspieler>();
        Sprache = "";
        FSK = 0;
    }

    public Film(String titel, int erscheinungsjahr, String genre, int laufzeit, List<Schauspieler> cast, String sprache, int fSK) {
        Titel = titel;
        Erscheinungsjahr = erscheinungsjahr;
        Genre = genre;
        Laufzeit = laufzeit;
        Cast = cast;
        Sprache = sprache;
        FSK = fSK;
    }

    public Film() {
        Titel = "";
        Erscheinungsjahr = 0;
        Genre = "";
        Laufzeit = 0;
        Cast = new ArrayList<Schauspieler>();
        Sprache = "";
        FSK = 0;
    }

    public String get_Titel() {
        return Titel;
    }
    public void set_Titel(String titel) {
        Titel = titel;
    }

    public int get_Erscheinungsjahr() {
        return Erscheinungsjahr;
    }
    public void set_Erscheinungsjahr(int erscheinungsjahr) {
        Erscheinungsjahr = erscheinungsjahr;
    }

    public String get_Genre() {
        return Genre;
    }
    public void set_Genre(String genre) {
        Genre = genre;
    }

    public int get_Laufzeit() {
        return Laufzeit;
    }
    public void set_Laufzeit(int laufzeit) {
        Laufzeit = laufzeit;
    }

    public List<Schauspieler> get_Cast() {
        return Cast;
    }
    public void set_Cast(List<Schauspieler> cast) {
        Cast = cast;
    }

    public String get_Sprache() {
        return Sprache;
    }
    public void set_Sprache(String sprache) {
        Sprache = sprache;
    }

    public int get_FSK() {
        return FSK;
    }
    public void set_FSK(int fSK) {
        FSK = fSK;
    }
}