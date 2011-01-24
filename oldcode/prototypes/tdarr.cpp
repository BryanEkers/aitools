#include <iostream>
using namespace std;

int main(){

  unsigned char ***three;
  int rows;
  int cols;
  int laye;

  cout << "rows : ";
  cin >> rows;
  cout << "cols : ";
  cin >> cols;
  cout << "laye : ";
  cin >> laye;

  a = new unsigned char **[rows];

  for (int i=0; i<rows; ++i){
    for (int j=0; j<cols; ++j){
      a[i] = new unsigned char *[cols];
      for (int k=0; k<laye; ++k){
        a[i][j]
      }
    }
  }

  return 0;
}
