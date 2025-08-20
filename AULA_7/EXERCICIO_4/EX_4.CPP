#include <iostream>
#include <vector>

void lerMatriz(int matriz[3][3], char nomeMatriz) {
    std::cout << "Preencha a Matriz " << nomeMatriz << ":" << std::endl;
    for (int i = 0; i < 3; ++i) {
        for (int j = 0; j < 3; ++j) {
            std::cout << "Elemento [" << i << "][" << j << "]: ";
            std::cin >> matriz[i][j];
        }
    }
    std::cout << std::endl;
}

void exibirMatriz(int matriz[3][3]) {
    for (int i = 0; i < 3; ++i) {
        for (int j = 0; j < 3; ++j) {
            std::cout << matriz[i][j] << "\t";
        }
        std::cout << std::endl;
    }
}

int main() {
    int matrizA[3][3];
    int matrizB[3][3];
    int matrizResultado[3][3] = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}};

    // 1. Ler as duas matrizes
    lerMatriz(matrizA, 'A');
    lerMatriz(matrizB, 'B');

    for (int i = 0; i < 3; ++i) {
        for (int j = 0; j < 3; ++j) {
            for (int k = 0; k < 3; ++k) {
                matrizResultado[i][j] += matrizA[i][k] * matrizB[k][j];
            }
        }
    }

    std::cout << "--- MATRIZ RESULTADO (A * B) ---" << std::endl;
    exibirMatriz(matrizResultado);

    return 0;
}