// C++ code
//
#define ledr 2
#define ledg 3
#define ledb 4
#define btn 7

int btnClicado=0; 
int btnLiberado=0;
int ciclo=0;

void setup() {
  pinMode(ledr, OUTPUT);
  pinMode(ledg, OUTPUT);
  pinMode(ledb, OUTPUT);
  pinMode(btn, INPUT);
}

void definirCor(int upColorRed, int upColorGreen, int upColorBlur) {
  digitalWrite(ledr, upColorRed);
  digitalWrite(ledg, upColorGreen);
  digitalWrite(ledb, upColorBlur);
}

void trocarLed() {
  switch(ciclo) {
    case 0:
      definirCor(1, 0, 0);
    break;
    case 1:
      definirCor(0, 1, 0);
    break;
    case 2:
      definirCor(0, 0, 1);
    break;
    case 3:
      definirCor(1, 1, 0);
    break;
    case 4:
      definirCor(1, 1, 1);
    break;
    case 5:
      definirCor(0, 1, 1);
    break;
    case 6:
      definirCor(1, 0, 1);
    break;
    default:
      ciclo=0;
  }
}

void keyup() {
  if((btnClicado == 1 and btnLiberado == 1))
  {
    btnClicado=0; 
    btnLiberado=0;
    ciclo++;
  }

    trocarLed();
}

void loop() {
  if(digitalRead(btn)== HIGH)
  {
    btnClicado = 1;
    btnLiberado = 0;
  }
  else
  {
    btnLiberado = 1;
  }

  keyup();
}
