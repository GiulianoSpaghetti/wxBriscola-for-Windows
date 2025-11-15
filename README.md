![made in parco grifeo](https://github.com/user-attachments/assets/79e7608a-aedb-4b85-bd71-46650c120667)

# wxBriscola-for-Windows
[wxBriscola](https://github.com/numerunix/wxBriscola) per Visual Studio

Questo gioco dimostra che la teoria dei giochi è vera: l'algorimo brevettato funziona su tutti i giochi di carte senza piatto.

## Bug conosciuti
Se si attivano le notifiche (i toast) il programma su windows 11 non si chiude più e necessita di essere chiuso a mano.
Su windows 11 i toast non vengono proprio mostrati.

## Video di presentazione

https://www.youtube.com/watch?v=kODrecClKoc

## Come installare

## Su Windows

[![pling](http://numeronesoft.ddns.net:8080/images/pling.png)](https://www.pling.com/p/2310373)

## Donazione

http://numerone.altervista.org/donazioni.php

## Bug noti

Su windows 10 e 11 23h2 i toast potrebbero non essere mostrati e potrebbe rimanere appesa l'applicazione in fase di chiusura se si prova a usare i toast, se questo accade, deselezionare "mostra le cose più interessanti".

La disinstallazione del mazzo di carte non è gestita, ma nel file di configurazione del gioco ne rimane traccia, quindi disinstallando un mazzo il programma potrebbe  non avviarsi più.

Per ovviare al problema inserire il nome di una subdirectory di C:\Program Files\wxBriscola\Mazzi indicante il vostro mazzo di default, che può non essere necessariamene il napoletano, perché le immagini non sono integrate nell'eseguibile.
