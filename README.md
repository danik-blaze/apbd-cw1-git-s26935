APBD cw1 - Git exercise

Project contains console app for statistics

\## Zadanie 5 - odpowiedź

Merge gałęzi feature-max nie był fast-forward, ponieważ na gałęzi main pojawił się nowy commit (aktualizacja README) po utworzeniu gałęzi feature-max. W takiej sytuacji Git nie może po prostu przesunąć wskaźnika main – musi utworzyć dodatkowy commit scalający (merge commit), który łączy dwie różne gałęzie.



\## Zadanie 7 - rozwiązanie konfliktu

Konflikt powstał w pliku `Program.cs` w linii z komunikatem powitalnym. Na gałęzi `main` zmieniłem tekst na "Enter numbers (space separated):", a na gałęzi `feature-conflict` na "Welcome! Please enter numbers separated by spaces:". Podczas merge Git nie wiedział, którą wersję wybrać. Rozwiązałem konflikt, wybierając wersję z `main` (lub łącząc obie – opisz swoją decyzję).

### 1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?
Git wykonuje **fast-forward**, gdy gałąź, którą chcemy włączyć (np. `feature`), zawiera wszystkie commity z gałęzi docelowej (`main`) i nie ma na `main` nowych commitów od momentu utworzenia gałęzi – wystarczy przesunąć wskaźnik.  
**Merge commit** powstaje, gdy obie gałęzie (docelowa i włączana) mają własne, rozbieżne commity – Git musi utworzyć nowy commit scalający.

### 2. Czym w praktyce różni się merge od rebase?
- **Merge** tworzy dodatkowy commit scalający i zachowuje historię rozgałęzień (widoczne są wszystkie równoległe ścieżki). Jest bezpieczny dla współpracy, bo nie zmienia istniejących commitów.
- **Rebase** przepisuje commity z jednej gałęzi na czubek drugiej, tworząc liniową historię. Zmienia hashe commitów, przez co nie powinno się go używać na gałęziach współdzielonych publicznie. Daje czystszy log, ale może powodować konflikty przy każdym przepisanym commicie.

### 3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?
(W twoim przypadku już jest, ale możesz uzupełnić o konkretną decyzję, np.)  
Konflikt powstał w `Program.cs` przy zmianie komunikatu powitalnego. Wybrałem wersję z gałęzi `main` (`"Enter numbers (space separated):"`), ponieważ jest krótsza i bardziej techniczna. Po rozwiązaniu usunąłem markery `<<<<<<<`, `=======`, `>>>>>>>` i dokończyłem merge.