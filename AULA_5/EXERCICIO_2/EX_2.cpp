#include <iostream>
#include <random>
#include <limits>

using namespace std;

int main() {
    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1, 100);
    int valorInteiro = distribuicao(numAleatorio);

    int tentativa;
    int contador = 0;

    cout << "Tente adivinhar o número entre 1 e 100!" << endl;

    do {
        bool entradaValida = false;
        
        do {
            cout << "Digite seu palpite: ";
            cin >> tentativa;

            if (cin.fail()) {
                cout << "Entrada inválida! Digite um número inteiro." << endl;
                cin.clear(); // Limpa o erro do cin
                cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Descarta entrada inválida
            } else {
                entradaValida = true;
            }

        } while (!entradaValida); // Repete até receber um número válido

        contador++;

        if (tentativa > valorInteiro)
            cout << "Chutou alto!" << endl;
        else if (tentativa < valorInteiro)
            cout << "Chutou baixo!" << endl;

    } while (tentativa != valorInteiro);

    cout << "Acertou! O número era " << valorInteiro << ". Tentativas: " << contador << endl;

    return 0;
}
