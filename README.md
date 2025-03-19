# Platformy Programistyczne .NET i Java - Laboratorium 1

# Klasy i ich funkcje

### 1. `Item`

**Opis**: Reprezentuje pojedynczy przedmiot w problemie plecakowym.

**Pola**:
- `Weight` (int): Waga przedmiotu.
- `Value` (int): Wartość przedmiotu.
- `Index` (int): Indeks lub identyfikator przedmiotu.
- `ratio` (float): Ratio pomiędzy ceną a wagą

**Konstruktor**:
- `Item(int weight, int value, int index)`: Inicjalizuje nowy obiekt klasy `Item` z określoną wagą, wartością i indeksem.
- `Item(int id, Random random): Inicjalizuje nowy obiekt klasy `Item` z losową wagą, wartością oraz podanym indeksem.

**Metody**:
- `toString()` : przeciążona metoda aby wyświetlać parametry przedmiotu

### 2. `Problem`

**Opis**: Reprezentuje instancję problemu plecakowego, zawierającą listę przedmiotów oraz metody do generowania i rozwiązywania problemu.

**Pola**:
- `Items` (List<Item>): Lista dostępnych przedmiotów.
- `Capacity` (int): Pojemność plecaka.

**Konstruktory**:
- `Problem()`: Inicjalizuje nową instancję pustego problemu
- `Problem(int numberOfItems, int seed)`: Inicjalizuje nową instancję problemu plecakowego z określoną liczbą przedmiotów oraz nasionem dla generatora liczb losowych.

**Metody**:
- `GenerateItems(int numberOfItems, int seed)`: Generuje listę przedmiotów o losowych wagach i wartościach na podstawie podanej liczby przedmiotów oraz nasienia.
- `Solve()`: Rozwiązuje problem plecakowy za pomocą algorytmu zachłannego, zwracając listę wybranych przedmiotów oraz ich łączną wartość i wagę.
- `toString()`: przeciążona metoda aby wyświetlać zawartość plecaka
- `ItemAdd(int w, int p)`: Dodawnanie nowego przemiotu do plecka o zadanych parametrach

### 3. `Program`

**Opis**: Główna część wywołania programu w konsoli


# App

**Opis**: Realizacja zadania w wrersji okienkowej

# TestProject1

**Opis**: Realizacja testów jednostkowych dla wersji konsolowej

