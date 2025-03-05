// C++ code
//
#define led 5
#define btn 3
int btnClicado=0; 
int btnLiberado=0; 

void setup() {
  pinMode(led, OUTPUT);
  pinMode(btn, INPUT);
}

void trocarLed() {
  if(digitalRead(led) == HIGH) 
  {
    digitalWrite(led, LOW);
  }
  else
  {
    digitalWrite(led, HIGH);
  }
}

void keyup() {
  if((btnClicado == 1 and btnLiberado == 1))
  {
    btnClicado=0; 
    btnLiberado=0;
    trocarLed();
  }
}

void loop() {
  if(digitalRead(btn) == HIGH)
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
