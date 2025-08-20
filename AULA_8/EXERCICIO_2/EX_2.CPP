#include <iostream>
#include <string>
#include <vector>
#include <limits> // Necessário para numeric_limits

struct Livro {
    std::string Titulo;
    std::string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    double Preco;
};

int main() {
    Livro biblioteca[3];

    std::cout << "--- CADASTRO DE LIVROS ---" << std::endl;

    for (int i = 0; i < 3; ++i) {
        std::cout << "\n--- Livro " << i + 1 << " ---" << std::endl;
        
        std::cout << "Titulo: ";
        std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
        std::getline(std::cin, biblioteca[i].Titulo);

        std::cout << "Autor: ";
        std::getline(std::cin, biblioteca[i].Autor);

        std::cout << "Ano de Publicacao: ";
        std::cin >> biblioteca[i].AnoPublicacao;

        std::cout << "Numero de Paginas: ";
        std::cin >> biblioteca[i].NumeroPaginas;

        std::cout << "Preco (R$): ";
        std::cin >> biblioteca[i].Preco;
    }

    double precoTotal = 0;
    int somaPaginas = 0;

    for (int i = 0; i < 3; ++i) {
        precoTotal += biblioteca[i].Preco;
        somaPaginas += biblioteca[i].NumeroPaginas;
    }
    double mediaPaginas = static_cast<double>(somaPaginas) / 3.0;

    std::cout << "\n-------------------------------------------------" << std::endl;
    std::cout.precision(2); // Define a precisão para 2 casas decimais
    std::cout << "Preco total dos livros: R$ " << std::fixed << precoTotal << std::endl;
    std::cout << "Media de paginas dos livros: " << std::fixed << mediaPaginas << " paginas" << std::endl;
    std::cout << "-------------------------------------------------" << std::endl;

    return 0;
}