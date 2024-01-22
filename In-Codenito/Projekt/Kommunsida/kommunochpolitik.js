
const omForvaltningar = {
    forvaltningsNamn: "Om våra förvaltningar",
    organisationInfo: "Kommunens förvaltningsorganisation är indelad i sex förvaltningar/kontor, alla med sitt speciffika verksamhetsområde. Personalen som sköter de dagliga frågorna inom kommunen är anställda i en förvaltning eller ett bolag. \
    Du kan läsa mer om de individuella förvaltningarna eller kontakta dem med hjälp av flikarna till höger.",
    antalAnstallda: "Totalt över alla förvaltningar är vi X anställda.",
    kontaktNamn: "Växel: ",
    kontaktNr: "4545-65400"
};

const kulturFritid = {
    forvaltningsNamn: "Kultur och Fritid",
    organisationInfo: "Kultur- och fritidsförvaltningen ger stöd till studieförbund och föreningar, ansvarar för ungdomsverksamhet, bad och uthyrning av kommunala idrottsanläggningar. \
    Förvaltningen ansvarar också för biblioteket och den övriga kommunala kulturverksamheten i form av kulturarrangemang, kultur i förskolan och konst. Kulturskolan är också en del av vår förvaltning.",
    antalAnstallda: "X",
    kontaktNamn: "Tim Falk: ",
    kontaktNr: "4545-65410"
};

const tekniskaKontoret = {
    forvaltningsNamn: "Tekniska Kontoret",
    organisationInfo: "Tekniska kontoret har ansvaret för kommunens gator, vatten- och avlopp, fastigheter, mark, naturområden, parker och parkeringar. \
    Tekniska kontoret har också ansvar för avfallshantering, hamnar och parkeringsverksamhet samt planering för kommunens bostads- och markförsörjning. ",
    antalAnstallda: "X",
    kontaktNamn: "Sean Banan:",
    kontaktNr: "4545-65420"
};

const utbildningsForvaltningen = {
    forvaltningsNamn: "Utbildningsförvaltningen",
    organisationInfo: "Vi ansvarar för barnomsorgen och alla skolor från förskola upp till gymnasienivå, inklusive vuxenutbildningen. Barn och utbildningsnämnden har det politiska ansvaret för verksamheten.",
    antalAnstallda: "X",
    kontaktNamn: "Genard Laha: ",
    kontaktNr: "4545-65430"
};

const socialForvaltningen = {
    forvaltningsNamn: "Socialförvaltningen",
    organisationInfo: "Vår uppgift är att bistå behövande i Incodenito kommun med insatser i form av stöd, vård och omsorg när ni har rätt till det. \
    Våra främsta ansvarsområden är: biståndshandläggning, stöd och omsorg till äldre, stöd och omsorg till personer med fysisk och psykisk funktionsnedsättning, stöd och omsorg till individ och familjer.",
    antalAnstallda: "X",
    kontaktNamn: "Frans Lindström: ",
    kontaktNr: "4545-65440"
};

const raddningsTjansten = {
    forvaltningsNamn: "Räddningstjänsten",
    organisationInfo: "Den kommunala räddningstjänstens uppgift är att förebygga olyckor och begränsa skadorna när de inträffar. Det går inte att försäkra sig mot alla olyckor – exempelvis bränder, utsläpp av farliga ämnen eller översvämningar. \
    Men genom räddningstjänsten finns beredskap för att hindra och begränsa skador.",
    antalAnstallda: "X",
    kontaktNamn: "Byggare Bob: ",
    kontaktNr: "4545-65450"
};

const stadsKontoret = {
    forvaltningsNamn: "Stadskontoret",
    organisationInfo: "Stadsbyggnadskontoret ansvarar för den fysiska planeringen i Incodenito kommun. Kontoret arbetar med översiktlig planering och detaljplaner, bygglov, stadsmätning, fastighetsbildning samt bostadsanpassning. \
    Mer konkret innebär det att stadskontoret ansvarar för Incodenito kommuns översiktsplan som beskriver hur Incodenitos fysiska miljö ska utvecklas på lång sikt. \
    Vi ansvarar också för detaljplanering som styr lokalisering och utformning av områden, bebyggelse, parker, grönområden, infrastruktur med mer.",
    antalAnstallda: "X",
    kontaktNamn: "Växel:",
    kontaktNr: "4545-65460"
};


var omForvaltningarKnapp = document.getElementById("omForvaltningarKnapp");

var kulturFritidKnapp = document.getElementById("kulturFritidKnapp");

var tekniskaKontoretKnapp = document.getElementById("tekniskaKontoretKnapp");

var utbildningsForvaltningenKnapp = document.getElementById("utbildningsForvaltningenKnapp");

var socialForvaltningenKnapp = document.getElementById("socialForvaltningenKnapp");

var raddningsTjanstenKnapp = document.getElementById("raddningsTjanstenKnapp");

var forvaltningarInfoKnapp = document.getElementById("stadsKontoretKnapp");




function changeInfo(vilkenKnapp) {

    switch (vilkenKnapp) {
        case omForvaltningar:
            var information = omForvaltningar;
            break;
        case kulturFritid:
            var information = kulturFritid;
            break;
        case tekniskaKontoret:
            var information = tekniskaKontoret;
            break;
        case utbildningsForvaltningen:
            var information = utbildningsForvaltningen;
            break;
        case socialForvaltningen:
            var information = socialForvaltningen;
            break;
        case raddningsTjansten:
            var information = raddningsTjansten;
            break;
        case stadsKontoret:
            var information = stadsKontoret;
            break;
        default:
            var information = "nisse";
            break;
    }

    document.getElementById("forvaltningsNamn").textContent = information.forvaltningsNamn;
    document.getElementById("orgInfo").textContent = information.organisationInfo;
    document.getElementById("antalAnstallda").textContent = information.antalAnstallda;
    document.getElementById("kontaktNamn").textContent = information.kontaktNamn;
    document.getElementById("telefonNr").textContent = information.kontaktNr;
    document.getElementById("telefonNr").setAttribute("href", "tel:" + information.kontaktNr);
}
