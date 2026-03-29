APBD cw1 - Git exercise

Project contains console app for statistics

\## Zadanie 5 - odpowiedź

Merge gałęzi feature-max nie był fast-forward, ponieważ na gałęzi main pojawił się nowy commit (aktualizacja README) po utworzeniu gałęzi feature-max. W takiej sytuacji Git nie może po prostu przesunąć wskaźnika main – musi utworzyć dodatkowy commit scalający (merge commit), który łączy dwie różne gałęzie.



\## Zadanie 7 - rozwiązanie konfliktu

Konflikt powstał w pliku `Program.cs` w linii z komunikatem powitalnym. Na gałęzi `main` zmieniłem tekst na "Enter numbers (space separated):", a na gałęzi `feature-conflict` na "Welcome! Please enter numbers separated by spaces:". Podczas merge Git nie wiedział, którą wersję wybrać. Rozwiązałem konflikt, wybierając wersję z `main` (lub łącząc obie – opisz swoją decyzję).

