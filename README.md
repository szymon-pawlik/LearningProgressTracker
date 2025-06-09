📈 Learning Progress Tracker
Learning Progress Tracker to aplikacja desktopowa dla systemu Windows, stworzona w technologii C# WinForms. Jej głównym celem jest pomoc uczniom i osobom uczącym się w organizacji zadań, śledzeniu terminów i monitorowaniu postępów w nauce poprzez system ocen.

Projekt ten jest doskonałym przykładem aplikacji okienkowej zorientowanej na zarządzanie danymi, z czytelnym interfejsem użytkownika i jasno zdefiniowanymi funkcjami.

✨ Kluczowe Funkcje
Aplikacja została podzielona na dwa główne moduły: Zadania i Oceny.

Zarządzanie Zadaniami
Dodawanie i edycja zadań: Umożliwia tworzenie nowych zadań z opisem oraz modyfikację istniejących.

Przeglądanie listy zadań: Wyświetla wszystkie aktywne i ukończone zadania.

Rozwiązywanie zadań: Pozwala na oznaczanie zadań jako wykonane.

Śledzenie Postępów
Dodawanie i edycja ocen: Prosty formularz do wprowadzania ocen i ich późniejszej modyfikacji.

Generowanie raportów: Możliwość przeglądania podsumowania postępów na podstawie wprowadzonych ocen.

Panel główny (Dashboard): Centralny punkt aplikacji, który na bieżąco wyświetla kluczowe statystyki:

Liczbę aktywnych zadań.

Liczbę zadań już rozwiązanych.

Całkowitą liczbę ocenionych prac.

🛠️ Technologie i Struktura
Język: C#

Platforma: .NET Framework / .NET

Interfejs użytkownika: Windows Forms (WinForms)

Środowisko deweloperskie: Visual Studio

Struktura Projektu
Aplikacja opiera się na architekturze wielookienkowej. Kluczowe komponenty to:

Modele Danych:

Task.cs - Definiuje strukturę pojedynczego zadania.

Grade.cs - Definiuje strukturę pojedynczej oceny.

Główny Formularz:

MainForm.cs - Centralny punkt aplikacji, zawierający menu i dashboard.

Formularze Modułu Zadań:

AddTaskForm.cs, ViewTasksForm.cs, EditTaskForm.cs, SolveTaskForm.cs.

Formularze Modułu Ocen:

AddGradeForm.cs, EditGradeForm.cs, ViewReportForm.cs.

⚙️ Uruchomienie Projektu
Projekt został stworzony w Visual Studio i najłatwiej go uruchomić za pomocą tego środowiska.

Sklonuj repozytorium:

git clone https://github.com/twoj-login/twoje-repozytorium.git

Otwórz rozwiązanie w Visual Studio:
Odszukaj i otwórz plik z rozszerzeniem .sln w głównym folderze projektu.

Zbuduj projekt:
Wybierz z menu Build -> Build Solution (lub naciśnij Ctrl+Shift+B).

Uruchom aplikację:
Kliknij przycisk Start (lub naciśnij F5).
