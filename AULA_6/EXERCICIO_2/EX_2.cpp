#include <iostream>

void mostrarTabuada() {
    int numero;
    std::cout << "\n--- Tabuada ---" << std::endl;
    std::cout << "Digite um numero para ver sua tabuada: ";
    std::cin >> numero;
    
    for (int i = 1; i <= 10; ++i) {
        std::cout << numero << " x " << i << " = " << (numero * i) << std::endl;
    }
}


void calcularFatorial() {
    int numero;
    long long fatorial = 1;
    std::cout << "\n--- Fatorial ---" << std::endl;
    std::cout << "Digite um numero positivo para calcular o fatorial: ";
    std::cin >> numero;
    
    if (numero < 0) {
        std::cout << "Nao e possivel calcular fatorial de numero negativo." << std::endl;
    } else {
        for (int i = 1; i <= numero; ++i) {
            fatorial *= i;
        }
        std::cout << "O fatorial de " << numero << " e: " << fatorial << std::endl;
    }
}

int main() {
    int opcao;
    
    do {
        std::cout << "\n--- MENU DE EXERCICIOS ---" << std::endl;
        std::cout << "1. Ver Tabuada" << std::endl;
        std::cout << "2. Calcular Fatorial" << std::endl;
        std::cout << "0. Sair" << std::endl;
        std::cout << "Escolha uma opcao: ";
        std::cin >> opcao;
        
        switch (opcao) {
            case 1:
                mostrarTabuada();
                break;
            case 2:
                calcularFatorial();
                break;
            case 0:
                std::cout << "Encerrando o programa..." << std::endl;
                break;
            default:
                std::cout << "Opcao invalida. Tente novamente." << std::endl;
        }
    } while (opcao != 0);
    
    return 0;
}