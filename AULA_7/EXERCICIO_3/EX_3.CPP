#include <iostream>
#include <string>
#include <vector>

void exibirCidades() {
    std::cout << "Cidades disponiveis:" << std::endl;
    std::cout << "0: Vitoria" << std::endl;
    std::cout << "1: Belo Horizonte" << std::endl;
    std::cout << "2: Rio de Janeiro" << std::endl;
    std::cout << "3: Sao Paulo" << std::endl;
}

int main() {
    int distancias[4][4] = {
        {0, 524, 521, 882},
        {524, 0, 434, 586},
        {521, 434, 0, 429},
        {882, 586, 429, 0}
    };

    std::string cidades[] = {"Vitoria", "Belo Horizonte", "Rio de Janeiro", "Sao Paulo"};

    int cidadeOrigem, cidadeDestino;

    do {
        exibirCidades();
        std::cout << "\nInforme a cidade de origem (0-3): ";
        std::cin >> cidadeOrigem;

        std::cout << "Informe a cidade de destino (0-3): ";
        std::cin >> cidadeDestino;

        if (cidadeOrigem >= 0 && cidadeOrigem < 4 && cidadeDestino >= 0 && cidadeDestino < 4) {
            if (cidadeOrigem == cidadeDestino) {
                std::cout << "Origem e destino sao iguais. Encerrando o programa." << std::endl;
            } else {
                int distancia = distancias[cidadeOrigem][cidadeDestino];
                std::cout << "\nA distancia entre " << cidades[cidadeOrigem]
                          << " e " << cidades[cidadeDestino] << " e de "
                          << distancia << " km.\n" << std::endl;
            }
        } else {
            std::cout << "Selecao invalida. Por favor, insira um numero entre 0 e 3.\n" << std::endl;
        }

    } while (cidadeOrigem != cidadeDestino);

    return 0;
}