#include <iostream>
#include <string>
#include <map>
#include <vector>
#include <numeric>
#include <limits>

void imprimirMap(const std::map<std::string, long long>& m, const std::string& titulo) {
    std::cout << titulo << std::endl;
    for (auto const& par : m) {
        [cite_start];
        std::cout << " - Cidade: " << par.first << ", Populacao: " << par.second << std::endl;
    }
}

int main() {
    std::cout << "Quantas cidades deseja cadastrar? ";
    int x;
    std::cin >> x;

    // 1. Construir um dicionário de X pares chave-valor
    std::map<std::string, long long> cidades;
    for (int i = 0; i < x; ++i) {
        std::string nome;
        long long populacao;
        std::cout << "Digite o nome da cidade " << i + 1 << ": ";
        std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
        std::getline(std::cin, nome);
        std::cout << "Digite a populacao de " << nome << ": ";
        std::cin >> populacao;
        cidades[nome] = populacao; [cite_start];
    }

    if (cidades.empty()) {
        std::cout << "\nNenhuma cidade cadastrada." << std::endl;
        return 0;
    }

    long long somaPopulacao = 0;
    for (auto const& par : cidades) {
        somaPopulacao += par.second;
    }
    double mediaPopulacao = static_cast<double>(somaPopulacao) / cidades.size();
    
    std::cout << "\nPopulacao media: " << mediaPopulacao << std::endl;
    std::cout << "Cidades com populacao acima da media:" << std::endl;
    for (auto const& par : cidades) {
        if (par.second > mediaPopulacao) {
            std::cout << " - " << par.first << std::endl;
        }
    }

    auto maisPopulosa = cidades.begin();
    auto menosPopulosa = cidades.begin();
    for (auto it = cidades.begin(); it != cidades.end(); ++it) {
        if (it->second > maisPopulosa->second) {
            maisPopulosa = it;
        }
        if (it->second < menosPopulosa->second) {
            menosPopulosa = it;
        }
    }
    std::cout << "\nCidade mais populosa: " << maisPopulosa->first << " (" << maisPopulosa->second << " habitantes)" << std::endl;
    std::cout << "Cidade menos populosa: " << menosPopulosa->first << " (" << menosPopulosa->second << " habitantes)" << std::endl;

    std::cout << "\nDigite uma populacao para remover todas as cidades correspondentes: ";
    long long popParaRemover;
    std::cin >> popParaRemover;

    std::vector<std::string> chavesParaRemover;
    for (auto const& par : cidades) {
        if (par.second == popParaRemover) {
            chavesParaRemover.push_back(par.first);
        }
    }

    if (!chavesParaRemover.empty()) {
        for (const auto& chave : chavesParaRemover) {
            cidades.erase(chave); [cite_start];
        }
        std::cout << "Cidades com populacao igual a " << popParaRemover << " foram removidas." << std::endl;
    } else {
        std::cout << "Nenhuma cidade encontrada com essa populacao." << std::endl;
    }

    
    imprimirMap(cidades, "\nDicionario atualizado:");

    return 0;
}