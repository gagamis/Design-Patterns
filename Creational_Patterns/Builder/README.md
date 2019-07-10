Az építő (builder pattern) programtervezési minta egy létrehozási (creational pattern) minta.  Ahelyett hogy nagyszámú konstruktort alkalmazna, az Építő minta egy másik objektumot, az építőt alkalmazza, mely minden egyes inicializációs paramétert lépésről lépésre kap meg, majd egyben adja vissza az elkészült objektumot.

Megoldást ad a gyár mintákkal kapcsolatos problémákra. A gyár minták nehezen boldogulnak a sok attribútummal rendelkező objektumokkal.
Az építő azonban lépésről lépésre építi fel az objektumot, állítja be az attribútumok értékét, míg végül
visszaadja a teljesen elkészült példányt.

A Builder osztály egy absztrakt felületet határoz meg, amely egy objektumot épít fel annak részeiből. A ConcreteBuilder, amely implementálja a Builder absztrakt metódusát, összeállítja az objektumot annak részeiből, az elkészült példányt pedig eltárolja. 
A Director hozza létre az összetett objektumokat.
A Product a konstruálandó objektum típusa.

https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Builder_UML_class_diagram.svg/1280px-Builder_UML_class_diagram.svg.png
