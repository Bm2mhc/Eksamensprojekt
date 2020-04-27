# Eksamensprojekt
 Digital teknik eksamens projekt
 
## Projektet

Dette projekt er et navigationssystem lavet til Slotshaven Gymnasium. Det er designet til at være opstillet på skolen infotavle og klar til at blive brugt af en ny elev eller brobygger.

Programmet er lavet i Unity og er buildet til PC senere versioner skal være buildet til Android, men med tidspress kunne vi ikke få løst vores build problem. Build problemt var at Google Speech To Text ikke virkede efter build til Android.

*Se og downloade PC build her:*
https://drive.google.com/file/d/1OasCa2ggdrD_cwOxWRkSoY6TOy9zvcI-/view?usp=sharing

## API'er
Dette projekt bruger 2 API'er. Det første er Google Speech to Text. Google Speech to Text er en api skabt af Google som kan bruges til at transcribe ens udtalte sætning om til ord. Vi bruger det til at få den indtalet sætning analyseret og delt op så vi kan finde ud af hvilket lokale brugeren skal hen til. 

*Du kan læse mere her:*
https://cloud.google.com/speech-to-text/?utm_campaign=emea-emea-all-en-dr-bkws-all-all-trial-e-gcp-1008073&utm_term=KW_google+speech+to+text-NET_g-PLAC_&gclid=Cj0KCQjwhZr1BRCLARIsALjRVQPuhOG2q1gGPnPaMqgrpLcsMb9weEvFAvkSKTLmsOsje1y7HYEvBqsaAtm0EALw_wcB&utm_content=text-ad-none-any-DEV_c-CRE_253515259877-ADGP_Hybrid+%7C+AW+SEM+%7C+BKWS+%7E+EXA_M%3A1_EMEA_EN_Cloud_ML_Speech+API-KWID_43700053286084142-aud-606988878374%3Akwd-295515021979-userloc_1005098&utm_source=google&utm_medium=cpc&ds_rl=1245734

Det andet api vi bruger er et Lectio API. Lectio er de danske skoleelevers måde at se skema og få information på. Dette Lectio Api vi bruger er skabt af en klasse kammerat. Vi bruger API'et til at finde information om det lokale bruger vil se.

*Du kan læse mere her*
https://lectioapi.dk/

## Her er lokalerne indbygget i programmet ved første udgave

### Lokaler
Rektor
Studievejledningen
VR lab
Proces
Teori
Biokemi
Fysik
Bibliotek
Teknologi
Byg
Musik
Kantinen

### Gange
10'er gang
20'er gang
30'er gang
43-44-45
56-47-48-49-50
50'er gang
60'er gang

### Andeet
Printer

## Fejl i produktet
En fejl i produktet var skemaet. Måden som Lectio API’et er lavet på gør det ikke smart hvis timerne ikke ligger inden for et module. Hvis man kigger på rektors skema og hun har et module 12:30 har desværret ved sætte det ind i projektet da den kun går efter skema timer som 8:15, 9:15. Derfor forsvinder disse timer fra vores skema oversigt. Samtidig er heldags moduler ikke vist som et heldags module og det må være noget man skal kigge på.

Lectio api’et tager alt for lang tid med at loaded. Det skal loades tidligere så brugeren ikke behøvere at vente særlig længe for at få skemaet. Det for det jo også til at virke mere dynamisk ved hjælp af overgangen mellem siderne.

Vi skal også have gjort noget ved flere keywords i en sætning. Det er et problem at man ikke kommer derhen man havde håbet når man siger “Rektor sagde at jeg...”. Det skal være noget der skal være fikset i næste version af programmet.

Til sidst har vi et problem når vi har build vores program. Build er når man publicere sit spil til den platform man vil. Når vi har et build til PC virker programmet perfekt og Lectio og Google API’erne virker fint, men build til android virker ikke. Vi har problemer med at få buildet vores program til android. Programmet selv virker, men Google API’et kan ikke virke. Den finder ikke noget Mikrofon tale. Problemet kan ikke findes på den tid vi havde før aflevering så det må være klart i næste version. Alternativt kan man ændre styresystemet på tablet'en så den kører Windows. Det vil gøre så programmet køre fint.

## Kommende ting
Her kommer vi ind på ting som vi fandt skal gøres bedre i version 2.0 som vi ikke havde tid til at fiks til perfektion.

### Flere keywords
Hvis vi havde mere tid til projektet vil det næste være at begynde på sætninger på med flere keywords. Det vil gøre det mere naturligt og føle mere intelligent. Det vil også være mere smart hvis der nu er sætninger hvor folk vil sige at “Rektor sagde jeg skulle gå herhen” og så den tog lokationen som rektor sagde personen skulle hen.

### Lectio API
Næst må vi få Lectio API’et til at virke helt. Vi må kunne lave et layout der virker hurtigere og kan så få ikke normal tid placeret timer til at stå på skemaet så det virker optimalt med studievejledningen og rektor. Vi skal også have hel dags modulere til kunne blive vist som heldags moduler. Dette kunne gøres ved en formel der tagere timens længde og ændre boksens størrelse henholdsvis. Dette skal gøres, men er nok ikke det sværeste at udføre.

### Lærer information
En anden ting der må komme i version 2.0 er lærer information, altså at man kan få information hvor en lærer befinder sig ved at sige navnet. Det vil også forgå ved hjælp af Lectio API’et og tjekke hvilke timer læreren har.

### Andre små ting
først skal der kommer vores statiske tekst. Dette vil sige at hvis man siger rektors kontor kommer der vejvisning og information at det er her rektor sidder. En anden ting der skulle komme vil være kantinepriser. Ved hjælp af Facebook api’et vil den hente kantine planen ned fra Facebook og vise det så man også kunne finde priser og mad retter.


