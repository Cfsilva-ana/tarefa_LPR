#include <iostream>
#include <vector>
using namespace std;
int main()
{
 vector<int> num(10); 
 
 cout << "Insira as 10 alturas:" << endl;

 if (cin)
 {
        for (int i = 0; i < num.size(); i++)
    {
        cout << "Altura " << i + 1 << ": ";
        cin >> num[i];
    }

    cout << "PAR: ";
    for (int i = 0; i < 10; i++) {
        if (num[i] % 2 == 0) {
            cout << num[i] << " ";
        }
    }

   
    cout << "\nÍMPAR: ";
    for (int i = 0; i < 10; i++) {
        if (num[i] % 2 != 0) {
            cout << num[i] << " ";
        }
    }


 }

 return 0;
}