#include <iostream>


int reverterNumero(int numero) {
    int reverso = 0;
    
    while (numero != 0) {
        int digito = numero % 10;
        reverso = reverso * 10 + digito;
        numero /= 10;
    }
    
    return reverso;
}

int main() {
    int numeroOriginal;
    
    std::cout << "Digite um numero inteiro: ";
    std::cin >> numeroOriginal;
    
    int numeroRevertido = reverterNumero(numeroOriginal);
    
    std::cout << "O reverso e: " << numeroRevertido << std::endl;
    
    return 0;
}