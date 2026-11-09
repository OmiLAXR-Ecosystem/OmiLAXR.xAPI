using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 33 items of the xAPI_Activities of the context observation as public properties.
    /// </summary>
    public sealed class xAPI_Activities_Observation_Subscores : xAPI_Activities {
        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer auf andere achtet/Rücksicht nimmt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/achtet_auf_anderenimmt_Ruecksicht
        /// </summary>
        public readonly xAPI_Activity achtet_auf_anderenimmt_Ruecksicht = new xAPI_Activity(
            context: "observation",
            key: "achtet_auf_anderenimmt_Ruecksicht",
            names: new Dictionary<string, string> {
                ["de-DE"] = "achtet auf anderenimmt Rücksicht" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer auf andere achtet/Rücksicht nimmt" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer eigene Gedanken klar und verständlich artikuliert
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/artikuliert_eigene_Gedanken_klar_und_verstaendlich
        /// </summary>
        public readonly xAPI_Activity artikuliert_eigene_Gedanken_klar_und_verstaendlich = new xAPI_Activity(
            context: "observation",
            key: "artikuliert_eigene_Gedanken_klar_und_verstaendlich",
            names: new Dictionary<string, string> {
                ["de-DE"] = "artikuliert eigene Gedanken klar und verständlich" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer eigene Gedanken klar und verständlich artikuliert" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer den Zielzustand stets im Blick behält
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/behaelt_den_Zielzustand_stets_im_Blick
        /// </summary>
        public readonly xAPI_Activity behaelt_den_Zielzustand_stets_im_Blick = new xAPI_Activity(
            context: "observation",
            key: "behaelt_den_Zielzustand_stets_im_Blick",
            names: new Dictionary<string, string> {
                ["de-DE"] = "behält den Zielzustand stets im Blick" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer den Zielzustand stets im Blick behält" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer stehts den Überblick behält
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/behaelt_stehts_den_Ueberblick
        /// </summary>
        public readonly xAPI_Activity behaelt_stehts_den_Ueberblick = new xAPI_Activity(
            context: "observation",
            key: "behaelt_stehts_den_Ueberblick",
            names: new Dictionary<string, string> {
                ["de-DE"] = "behält stehts den Überblick" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer stehts den Überblick behält" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer sich sprachlich an Lösung der Aufgabe beteiligt/Fragen stellt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/beteiligt_sich_sprachlich_an_Loesung_der_Aufgabestellt_Fragen
        /// </summary>
        public readonly xAPI_Activity beteiligt_sich_sprachlich_an_Loesung_der_Aufgabestellt_Fragen = new xAPI_Activity(
            context: "observation",
            key: "beteiligt_sich_sprachlich_an_Loesung_der_Aufgabestellt_Fragen",
            names: new Dictionary<string, string> {
                ["de-DE"] = "beteiligt sich sprachlich an Lösung der Aufgabe/stellt Fragen" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer sich sprachlich an Lösung der Aufgabe beteiligt/Fragen stellt" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer in schwierigen/unangenehmen Situationen gelassen und ruhig bleibt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/bleibt_in_schwierigenunangenehmen_Situationen_gelassen_und_ruhig
        /// </summary>
        public readonly xAPI_Activity bleibt_in_schwierigenunangenehmen_Situationen_gelassen_und_ruhig = new xAPI_Activity(
            context: "observation",
            key: "bleibt_in_schwierigenunangenehmen_Situationen_gelassen_und_ruhig",
            names: new Dictionary<string, string> {
                ["de-DE"] = "bleibt in schwierigen/unangenehmen Situationen gelassen und ruhig" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer in schwierigen/unangenehmen Situationen gelassen und ruhig bleibt" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer eigene Ideen entwickelt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/entwickelt_eigene_Ideen
        /// </summary>
        public readonly xAPI_Activity entwickelt_eigene_Ideen = new xAPI_Activity(
            context: "observation",
            key: "entwickelt_eigene_Ideen",
            names: new Dictionary<string, string> {
                ["de-DE"] = "entwickelt eigene Ideen" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer eigene Ideen entwickelt" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer erarbeitet ein klares Bild der Ausgangssituation/Problemstellung
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/erarbeitet_ein_klares_Bild_der_AusgangssituationProblemstellung
        /// </summary>
        public readonly xAPI_Activity erarbeitet_ein_klares_Bild_der_AusgangssituationProblemstellung = new xAPI_Activity(
            context: "observation",
            key: "erarbeitet_ein_klares_Bild_der_AusgangssituationProblemstellung",
            names: new Dictionary<string, string> {
                ["de-DE"] = "erarbeitet ein klares Bild der Ausgangssituation/Problemstellung" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer erarbeitet ein klares Bild der Ausgangssituation/Problemstellung" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer Möglichkeiten zur Strukturierung einer Aufgabe findet
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/findet_Moeglichkeiten_zur_Strukturierung_einer_Aufgabe
        /// </summary>
        public readonly xAPI_Activity findet_Moeglichkeiten_zur_Strukturierung_einer_Aufgabe = new xAPI_Activity(
            context: "observation",
            key: "findet_Moeglichkeiten_zur_Strukturierung_einer_Aufgabe",
            names: new Dictionary<string, string> {
                ["de-DE"] = "findet Möglichkeiten zur Strukturierung einer Aufgabe" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer Möglichkeiten zur Strukturierung einer Aufgabe findet" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer Bewegungen präzisegenau ausführt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/fuehrt_Bewegungen_praezisegenau_aus
        /// </summary>
        public readonly xAPI_Activity fuehrt_Bewegungen_praezisegenau_aus = new xAPI_Activity(
            context: "observation",
            key: "fuehrt_Bewegungen_praezisegenau_aus",
            names: new Dictionary<string, string> {
                ["de-DE"] = "führt Bewegungen präzise/genau aus" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer Bewegungen präzisegenau ausführt" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer Aufgaben zügig angeht
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/geht_Aufgaben_zuegig_an
        /// </summary>
        public readonly xAPI_Activity geht_Aufgaben_zuegig_an = new xAPI_Activity(
            context: "observation",
            key: "geht_Aufgaben_zuegig_an",
            names: new Dictionary<string, string> {
                ["de-DE"] = "geht Aufgaben zügig an" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer Aufgaben zügig angeht" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer respektvoll und tolerant mit Meinungsverschiedenheiten umgeht
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/geht_respektvoll_und_tolerant_mit_Meinungsverschiedenheiten_um
        /// </summary>
        public readonly xAPI_Activity geht_respektvoll_und_tolerant_mit_Meinungsverschiedenheiten_um = new xAPI_Activity(
            context: "observation",
            key: "geht_respektvoll_und_tolerant_mit_Meinungsverschiedenheiten_um",
            names: new Dictionary<string, string> {
                ["de-DE"] = "geht respektvoll und tolerant mit Meinungsverschiedenheiten um" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer respektvoll und tolerant mit Meinungsverschiedenheiten umgeht" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer nonverbal interagiert (zugewandte Körpersprache)
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/interagiert_nonverbal_zugewandte_Koerpersprache
        /// </summary>
        public readonly xAPI_Activity interagiert_nonverbal_zugewandte_Koerpersprache = new xAPI_Activity(
            context: "observation",
            key: "interagiert_nonverbal_zugewandte_Koerpersprache",
            names: new Dictionary<string, string> {
                ["de-DE"] = "interagiert nonverbal (zugewandte Körpersprache)" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer nonverbal interagiert (zugewandte Körpersprache)" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer Entfernungen/Höhen/Tiefen einschätzen kann (im Raum/von Gegenständen)
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/kann_EntfernungenHoehenTiefen_einschaetzen_im_Raumvon_Gegenstaenden
        /// </summary>
        public readonly xAPI_Activity kann_EntfernungenHoehenTiefen_einschaetzen_im_Raumvon_Gegenstaenden = new xAPI_Activity(
            context: "observation",
            key: "kann_EntfernungenHoehenTiefen_einschaetzen_im_Raumvon_Gegenstaenden",
            names: new Dictionary<string, string> {
                ["de-DE"] = "kann Entfernungen/Höhen/Tiefen einschätzen (im Raum/von Gegenständen)" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer Entfernungen/Höhen/Tiefen einschätzen kann (im Raum/von Gegenständen)" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer Maßstäbe im richtigen Verhältnis umsetzen kann (z.B. in Skizzen)
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/kann_Massstaebe_im_richtigen_Verhaeltnis_umsetzen_zB_in_Skizzen
        /// </summary>
        public readonly xAPI_Activity kann_Massstaebe_im_richtigen_Verhaeltnis_umsetzen_zB_in_Skizzen = new xAPI_Activity(
            context: "observation",
            key: "kann_Massstaebe_im_richtigen_Verhaeltnis_umsetzen_zB_in_Skizzen",
            names: new Dictionary<string, string> {
                ["de-DE"] = "kann Maßstäbe im richtigen Verhältnis umsetzen (z.B. in Skizzen)" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer Maßstäbe im richtigen Verhältnis umsetzen kann (z.B. in Skizzen)" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer Pläne/Skizzen lesen, verstehen und umsetzen kann
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/kann_PlaeneSkizzen_lesen_verstehen_und_umsetzen
        /// </summary>
        public readonly xAPI_Activity kann_PlaeneSkizzen_lesen_verstehen_und_umsetzen = new xAPI_Activity(
            context: "observation",
            key: "kann_PlaeneSkizzen_lesen_verstehen_und_umsetzen",
            names: new Dictionary<string, string> {
                ["de-DE"] = "kann Pläne/Skizzen lesen, verstehen und umsetzen" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer Pläne/Skizzen lesen, verstehen und umsetzen kann" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer auch komplexe Sachverhalte ausdrücken und/oder verstehen kann
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/kann_auch_komplexe_Sachverhalte_ausdruecken_undoder_verstehen
        /// </summary>
        public readonly xAPI_Activity kann_auch_komplexe_Sachverhalte_ausdruecken_undoder_verstehen = new xAPI_Activity(
            context: "observation",
            key: "kann_auch_komplexe_Sachverhalte_ausdruecken_undoder_verstehen",
            names: new Dictionary<string, string> {
                ["de-DE"] = "kann auch komplexe Sachverhalte ausdrücken und/oder verstehen" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer auch komplexe Sachverhalte ausdrücken und/oder verstehen kann" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer auch schwierige feinmotorische Handlungen ausführen kann
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/kann_auch_schwierige_feinmotorische_Handlungen_ausfuehren
        /// </summary>
        public readonly xAPI_Activity kann_auch_schwierige_feinmotorische_Handlungen_ausfuehren = new xAPI_Activity(
            context: "observation",
            key: "kann_auch_schwierige_feinmotorische_Handlungen_ausfuehren",
            names: new Dictionary<string, string> {
                ["de-DE"] = "kann auch schwierige feinmotorische Handlungen ausführen" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer auch schwierige feinmotorische Handlungen ausführen kann" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer andere ausreden lässt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/laesst_andere_ausreden
        /// </summary>
        public readonly xAPI_Activity laesst_andere_ausreden = new xAPI_Activity(
            context: "observation",
            key: "laesst_andere_ausreden",
            names: new Dictionary<string, string> {
                ["de-DE"] = "lässt andere ausreden" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer andere ausreden lässt" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein AkteuerRücksicht auf eigene Bedürfnisse  nimmt/die eigene Meinung vertritt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/nimmt_Ruecksicht_auf_eigene_Beduerfnissevertritt_die_eigene_Meinung
        /// </summary>
        public readonly xAPI_Activity nimmt_Ruecksicht_auf_eigene_Beduerfnissevertritt_die_eigene_Meinung = new xAPI_Activity(
            context: "observation",
            key: "nimmt_Ruecksicht_auf_eigene_Beduerfnissevertritt_die_eigene_Meinung",
            names: new Dictionary<string, string> {
                ["de-DE"] = "nimmt Rücksicht auf eigene Bedürfnisse/vertritt die eigene Meinung" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein AkteuerRücksicht auf eigene Bedürfnisse  nimmt/die eigene Meinung vertritt" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer das (eigene) Vorgehen plant und Schwerpunkte setzt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/plant_das_eigene_Vorgehen_und_setzt_Schwerpunkte
        /// </summary>
        public readonly xAPI_Activity plant_das_eigene_Vorgehen_und_setzt_Schwerpunkte = new xAPI_Activity(
            context: "observation",
            key: "plant_das_eigene_Vorgehen_und_setzt_Schwerpunkte",
            names: new Dictionary<string, string> {
                ["de-DE"] = "plant das (eigene) Vorgehen und setzt Schwerpunkte" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer das (eigene) Vorgehen plant und Schwerpunkte setzt" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer geeignete Mittel einsetzt/geeignete Handlungen ausführt, um das Ziel zu erreichen
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/setzt_geeignete_Mittel_einfuehrt_geeignete_Handlungen_aus_um_das_Ziel_zu_erreichen
        /// </summary>
        public readonly xAPI_Activity setzt_geeignete_Mittel_einfuehrt_geeignete_Handlungen_aus_um_das_Ziel_zu_erreichen = new xAPI_Activity(
            context: "observation",
            key: "setzt_geeignete_Mittel_einfuehrt_geeignete_Handlungen_aus_um_das_Ziel_zu_erreichen",
            names: new Dictionary<string, string> {
                ["de-DE"] = "setzt geeignete Mittel ein/führt geeignete Handlungen aus, um das Ziel zu erreichen" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer geeignete Mittel einsetzt/geeignete Handlungen ausführt, um das Ziel zu erreichen" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer eigene Bedürfnisse hinten anstellt, wenn es die Situation erfordert
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/stellt_eigene_Beduerfnisse_hinten_an_wenn_es_die_Situation_erfordert
        /// </summary>
        public readonly xAPI_Activity stellt_eigene_Beduerfnisse_hinten_an_wenn_es_die_Situation_erfordert = new xAPI_Activity(
            context: "observation",
            key: "stellt_eigene_Beduerfnisse_hinten_an_wenn_es_die_Situation_erfordert",
            names: new Dictionary<string, string> {
                ["de-DE"] = "stellt eigene Bedürfnisse hinten an, wenn es die Situation erfordert" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer eigene Bedürfnisse hinten anstellt, wenn es die Situation erfordert" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer verschiedne Lösungsansätze verfolgt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/verfolgt_verschiedene_Loesungsansaetze
        /// </summary>
        public readonly xAPI_Activity verfolgt_verschiedene_Loesungsansaetze = new xAPI_Activity(
            context: "observation",
            key: "verfolgt_verschiedene_Loesungsansaetze",
            names: new Dictionary<string, string> {
                ["de-DE"] = "verfolgt verschiedene Lösungsansätze" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer verschiedne Lösungsansätze verfolgt" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer sich höflich, freundlich und wohlwollend verhält
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/verhaelt_sich_hoeflich_freundlich_und_wohlwollend
        /// </summary>
        public readonly xAPI_Activity verhaelt_sich_hoeflich_freundlich_und_wohlwollend = new xAPI_Activity(
            context: "observation",
            key: "verhaelt_sich_hoeflich_freundlich_und_wohlwollend",
            names: new Dictionary<string, string> {
                ["de-DE"] = "verhält sich höflich, freundlich und wohlwollend" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer sich höflich, freundlich und wohlwollend verhält" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer geschriebene/bebilderte Informationen (z.B. Texte, Anweisungen) versteht
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/versteht_geschriebenebebilderte_Informationen_zB_Texte_Anweisungen
        /// </summary>
        public readonly xAPI_Activity versteht_geschriebenebebilderte_Informationen_zB_Texte_Anweisungen = new xAPI_Activity(
            context: "observation",
            key: "versteht_geschriebenebebilderte_Informationen_zB_Texte_Anweisungen",
            names: new Dictionary<string, string> {
                ["de-DE"] = "versteht geschriebene/bebilderte Informationen (z.B. Texte, Anweisungen)" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer geschriebene/bebilderte Informationen (z.B. Texte, Anweisungen) versteht" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer eigene Meinungen vertritt und sich dabei kompromissbereit zeigt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/vertritt_eigene_Meinungen_und_zeigt_sich_dabei_kompromissbereit
        /// </summary>
        public readonly xAPI_Activity vertritt_eigene_Meinungen_und_zeigt_sich_dabei_kompromissbereit = new xAPI_Activity(
            context: "observation",
            key: "vertritt_eigene_Meinungen_und_zeigt_sich_dabei_kompromissbereit",
            names: new Dictionary<string, string> {
                ["de-DE"] = "vertritt eigene Meinungen und zeigt sich dabei kompromissbereit" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer eigene Meinungen vertritt und sich dabei kompromissbereit zeigt" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer Ideen visualisiert oder umschreibt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/visualisiert_oder_umschreibt_Ideen
        /// </summary>
        public readonly xAPI_Activity visualisiert_oder_umschreibt_Ideen = new xAPI_Activity(
            context: "observation",
            key: "visualisiert_oder_umschreibt_Ideen",
            names: new Dictionary<string, string> {
                ["de-DE"] = "visualisiert oder umschreibt Ideen" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer Ideen visualisiert oder umschreibt" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer immer wieder von sich aus aktiv wird
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/wird_immer_wieder_von_sich_aus_aktiv
        /// </summary>
        public readonly xAPI_Activity wird_immer_wieder_von_sich_aus_aktiv = new xAPI_Activity(
            context: "observation",
            key: "wird_immer_wieder_von_sich_aus_aktiv",
            names: new Dictionary<string, string> {
                ["de-DE"] = "wird immer wieder von sich aus aktiv" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer immer wieder von sich aus aktiv wird" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer Intresse, Stolz oder Freude zeigt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/zeigt_Interesse_Stolz_oder_Freude
        /// </summary>
        public readonly xAPI_Activity zeigt_Interesse_Stolz_oder_Freude = new xAPI_Activity(
            context: "observation",
            key: "zeigt_Interesse_Stolz_oder_Freude",
            names: new Dictionary<string, string> {
                ["de-DE"] = "zeigt Interesse, Stolz oder Freude" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer Intresse, Stolz oder Freude zeigt" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer aktiv Interesse an anderen Menschen und ihren Ansichten/Ideen zeigt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/zeigt_aktiv_Interesse_an_anderen_Menschen_und_ihren_AnsichtenIdeen
        /// </summary>
        public readonly xAPI_Activity zeigt_aktiv_Interesse_an_anderen_Menschen_und_ihren_AnsichtenIdeen = new xAPI_Activity(
            context: "observation",
            key: "zeigt_aktiv_Interesse_an_anderen_Menschen_und_ihren_AnsichtenIdeen",
            names: new Dictionary<string, string> {
                ["de-DE"] = "zeigt aktiv Interesse an anderen Menschen und ihren Ansichten/Ideen" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer aktiv Interesse an anderen Menschen und ihren Ansichten/Ideen zeigt" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer sich hilfsbereit zeigt und andere aktiv unterstützt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/zeigt_sich_hilfsbereit_und_unterstuetzt_andere_aktiv
        /// </summary>
        public readonly xAPI_Activity zeigt_sich_hilfsbereit_und_unterstuetzt_andere_aktiv = new xAPI_Activity(
            context: "observation",
            key: "zeigt_sich_hilfsbereit_und_unterstuetzt_andere_aktiv",
            names: new Dictionary<string, string> {
                ["de-DE"] = "zeigt sich hilfsbereit und unterstützt andere aktiv" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer sich hilfsbereit zeigt und andere aktiv unterstützt" });

        /// <summary>
        /// Subscore (5/5 bzw. ++) wenn ein Akteuer Bewegungen schnell/routiniert ausübt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/uebt_Bewegungen_schnellroutiniert_aus
        /// </summary>
        public readonly xAPI_Activity uebt_Bewegungen_schnellroutiniert_aus = new xAPI_Activity(
            context: "observation",
            key: "uebt_Bewegungen_schnellroutiniert_aus",
            names: new Dictionary<string, string> {
                ["de-DE"] = "übt Bewegungen schnell/routiniert aus" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Subscore (5/5 bzw. ++) wenn ein Akteuer Bewegungen schnell/routiniert ausübt" });

        public xAPI_Activities_Observation_Subscores() 
            : base("observation") {
        }
    }
}