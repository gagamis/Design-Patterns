# Programtervezési minták

A programtervezési minták használatával rugalmasabban módosítható könnyebben, és jobban újrahasznosítható alkalmazásokat készíthetünk.

könnyen bővíthető, módosítható osztályszerkezetet kapunk, tehát rugalmas kódot
cserébe bonyolultabb, nehezebben átlátható kód és a nagyobb fejlesztési idő

A programtervezési minták, az építészetben jelentek meg legelsőként. 

Gang Of Four a szoftverfejlesztésben

Ha egy feladat újra előkerül a fejlesztés folyamán, akkor valószínűleg a megoldás hasonló lesz a korábbihoz.

összegyűjtötték a gyakran előforduló problémákat és a rájuk adott megoldásokat. A könyvben 23 mintát gyűjtöttek össze, amiket 3 csoport soroltak:
  1. LÉTREHOZÁSI (Creational Patterns) minták
  2. SZERKEZETI minták
  3. VISELKEDÉSI minták
  
  
#1. Létrehozási (creational patterns) minták
  sok new kulcsszóval ránk szakadó függőségeket megszüntetése
  
  1. Gyártófüggvény (Factory method)
  Ezt a tervezési mintát akkor használjuk, rendelkezünk egy szülőosztállyal, amelynek több leszármazottja van, és a bemeneten múlik, hogy mely gyermekosztályra van szükségünk. A minta egy gyártó metódusra teszi az objektumok létrehozásának felelősségét.
  
  2. Elvont gyár (Abstract factory)
  Az elvont gyár minta hasonló a gyártófüggvényhez, azonban magasabb absztrakciós szintet képvisel. A gyártók gyárának is szokták nevezni. Ebben a mintában nem if–else vagy catch blokkokkal határozzuk meg, hogy mely termékalosztályt példányosítjuk, hanem minden termékalosztályhoz tartozik egy gyár osztály, amely segítségével az absztrakt gyár elkészíti az objektumot. Absztrakt gyár alkalmazásával elrejthetjük a platformfüggő osztályokat a kliens elől.
  
    - gyártófüggvény a nevében magadott terméket adja vissza
    - az elkészítés algoritmusát egységbe tudjuk zárni.
    
  Előnye ha a gyártás folyamata változik, akkor azt csak egy helyen kell módosítani.
  A létrehozás algoritmusát egységbe tudjuk zárni. 
  Továbbá emelhetjük a termék absztrakciós szintjét, vagy elrejthetünk olyan információkat a kliens elől, amelyekre csak az objektum létrehozása miatt lenne szüksége. 
  Így, ha a gyártás folyamata változik, csak egy helyen szükséges módosítani a kódot. 
