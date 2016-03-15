# AiE_koderi

##Članovi tima:
1. Aksamovic Jasmin
2. Avdic Amna
3. Salkic Semir
4. Susa Maid

##Opis teme

Aplikacija je osmišljena da služi za registriranje i mjerenje elektrodermalne reakcije,čija analiza predstavlja vrlo značajnu komponentu kod ispitivanja pomoću detektora laži,i koja određuje koliko je  osoba koja je podvrgnuta ispitivanjima nervozna.Elektrodermalna reakcija (EDR) predstavlja promjenu otpora kože i jedna je od najčešćih mjera u psihofiziološkim ispitivanjima.Površinski sloj kože se sastoji od izumrlih ćelija koje tvore zaštitni sloj,koji ima veliki električni otpor (Suha koža ima otpor od milion ohma).Kada osobu podvrgnemo stresu,počinje se znojiti ,te na određenim dijelovima pada otpor kože. 

Aplikacija je implementirana korištenjem Arduino platforme ,te odgovarajućih električnih komponenti,te pruža širok spekar područja upotrebe: mogućnost mjerenja električnog otpora kože ispitanika, mogućnost analize električnog otpora kože ispitanika pri stresnim situacijama ,provjera iskrenosti ispitanika pri različitim ispitivanjima,te u svrhe zabave.


##Procesi

1.Proces kalibracije 

Prije službenog korištenja ,potrebno je izvršiti proces kalibracije detektora laži s obzirom da električni otpor osoba varira.Potrebno je da se korisnik nalazi u sjedećem stavu,te u opuštenom ambijentu u cilju povećanja tačnosti mjerenja.Korisniku postavljamo elektrode detektora na dlanove njegove lijeve i desne ruke.Ispitivač postavlja referentni otpor pomoću potenciometra.

1.1. Proces pre-test pitanja

Proces test pitanja je podproces procesa kalibracije instrumenta i vrlo je značajan korak u cjelokuponom procesu ispitivanja.Nakon davanja kratke upute korisniku o funkcionalnosti detektora te njegovoj primjeni,ispitivač postavlja set kratkih pitanja na koje korisnik odgovara sa da/ne . Test pitanja,koja moraju biti jednostavna,i ne uzrokuju uplitanje emocija ,omogućuju korisniku da se opusti.

2.Proces in-test pitanja

Nakon procesa pre-test pitanja,korisnika stavljamo pod stres postavljanjem težih i intimnijih pitanja (od velike važnosti je postavljati pitanja korisniku na koja može odgovoriti sa da/ne odgovorima).Kako se stres bude povećavao,korisnik će se početi znojiti ,što će dovesti do promjene električnog otpora kože,odnosno njenog smanjenja,a samim tim i smanjenja vrijednosti napona.

2.1.Proces analize odgovora korisnika

Proces analize odgovora korisnika je podproces procesa in-test pitanja.Nakon što korisnik odgovori na postavljeno pitanje sa da/ne odgovorom,jedna od LED dioda sklopa će se upaliti ovisno da li je dati odgovor istina ili laž.Sklop je preko Arduina povezan sa software-om na kompjuteru preko USB port-a.Sučelje aplikacije je organizovano tako da ,ovisno o odgovoru ispitanika, se ispisuje poruka ISTINA/LAŽ ,te određeni zvučni efekti .

3.Proces dodavanja  i izmjene pitanja

Ispitivaču je omogućen  unos novih pitanja ,te razvrstavanje istih u kategorije po temama.

4.Proces popravke kvara programa /update aplikacije

Ukoliko je došlo do greške ili aplikacija je naglo prestala funkcionisati,administrator vrši popravke i ažuriranje aplikacije.


##Funkcionalnosti

 •	 mogućnost mjerenja električnog otpora kože korisnika
 
 •  mogućnost analize električnog otpora kože korisnika pri stresnim situacijama
 
 •  mogućnost za unos novih pitanja
  
 •  mogućnost razvrstavanja pitanja po srodnim temama
   
 •  mogućnost feedback-a o najčešće postavljenim pitanjima

##Akteri

 1.	Ispitivač –ima potpuni pristup software-u,te vrši kalibraciju detektora laži ,postavljanje i dodavanje pitanja,i analizu odgovora ispitanika.
 
 2.	Korisnik- osoba koju stavljamo pod stres,postavljanjem serije pitanja i analiziramo promjenu njenog električnog otpora kože.


