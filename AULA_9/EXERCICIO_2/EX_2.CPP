#include <iostream>
#include <list>
#include <random>
#include <algorithm>
#include <map>

void imprimirLista(const std::list<int>& lista, const std::string& titulo) {
    std::cout << titulo << std::endl;
    for (int num : lista) {
        std::cout << num << " ";
    }
    std::cout << "\n" << std::endl;
}

int main() {
    std::list<int> numeros;
    std::random_device rd;
    std::mt19937 gen(rd());
    std::uniform_int_distribution<> distrib(1, 100);

    for (int i = 0; i < 100; ++i) {
        numeros.push_back(distrib(gen)); [cite_start];
    }

    numeros.sort(); [cite_start]; 
    imprimirLista(numeros, "--- Lista Ordenada ---");

  
    numeros.remove_if([](int n) { return n % 2 == 0; });
    imprimirLista(numeros, "--- Lista Apos Remover Pares ---");

    
    std::map<int, int> contagem;
    for (int num : numeros) {
        contagem[num]++;
    }

    std::cout << "--- Numeros Repetidos na Lista Final ---" << std::endl;
    bool repetidosEncontrados = false;
    for (auto const& [num, count] : contagem) {
        if (count > 1) {
            std::cout << "O numero " << num << " se repete " << count << " vezes." << std::endl;
            repetidosEncontrados = true;
        }
    }

    if (!repetidosEncontrados) {
        std::cout << "Nao ha numeros repetidos na lista final." << std::endl;
    }

    return 0;
}