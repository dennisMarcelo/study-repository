// C++ code
//
#define ledr 2
#define ledg 3
#define ledb 4
#define btn 7

class Button {
public:
  int btnClicado, btnLiberado, pino;

  Button(int p){
    pino=p;
    btnClicado=btnLiberado=0;
  }

  bool press(){
    if(digitalRead(pino)== HIGH)
    {
      btnClicado = 1;
      btnLiberado = 0;
    }
    else
    {
      btnLiberado = 1;
    }

    if((btnClicado == 1 and btnLiberado == 1)) 
    {
      btnClicado=0; 
      btnLiberado=0;
      return true;
    }
    else
    {
      return false;
    }
  }
};

class Led {
public:
  int pinoR,pinoG,pinoB,ciclo;
  Led(int pr, int pg, int pb):pinoR(pr), pinoG(pg), pinoB(pb){
    ciclo=0;
  }

  void trocar()  {
    ciclo++;

    switch(ciclo) {
      case 1:
        cor(1, 0, 0);
      break;
      case 2:
        cor(0, 1, 0);
      break;
      case 3:
        cor(0, 0, 1);
      break;
      case 4:
        cor(1, 1, 0);
      break;
      case 5:
        cor(1, 1, 1);
      break;
      case 6:
        cor(0, 1, 1);
      break;
      case 7:
        cor(1, 0, 1);
        ciclo=0;
      break;
      default:
        ciclo=0;
    }
    
  }

private:
  void cor(int r, int g, int b) {
    digitalWrite(ledr, r);
    digitalWrite(ledg, g);
    digitalWrite(ledb, b);
  }
};

void setup() {
  pinMode(ledr, OUTPUT);
  pinMode(ledg, OUTPUT);
  pinMode(ledb, OUTPUT);
  pinMode(btn, INPUT);
}

Button button(btn);
Led led(ledr, ledg, ledb);

void loop() {
  if(button.press()){
    led.trocar();
  }
}
