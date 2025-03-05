// C++ code
//
#define led_red 10
#define maximo 255
#define minimo 0
#define tmp 100

int time=7000; 

void setup() {
  pinMode(led_red, OUTPUT); //OUTPUT=saida    -   INPUT=entrada
}

void loop() {
 for(int i = minimo; i < maximo; i++) {
    analogWrite(led_red, i);
    delay(tmp);
  }

  for(int i = maximo; i > minimo; i--) {
    analogWrite(led_red, i);
    delay(tmp);
  }
}
