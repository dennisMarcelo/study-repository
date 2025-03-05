// C++ code
//

int pin13=13, pin10=10, TIME=500, TIME_2=2000;

void setup() {
    pinMode(pin13, OUTPUT); //OUTPUT=saida    -   INPUT=entrada
	pinMode(pin10, OUTPUT); //OUTPUT=saida    -   INPUT=entrada
}


void loop() {
  digitalWrite(pin13, HIGH); //HIGH=ligado (5v)   -   LOW=desligada (0v)
  delay(TIME);
  digitalWrite(pin13, LOW); //HIGH=ligado (5v)   -   LOW=desligada (0v)
  delay(TIME);
  
  
  
  digitalWrite(pin10, HIGH); //HIGH=ligado (5v)   -   LOW=desligada (0v)
  digitalWrite(pin10, LOW);
  digitalWrite(pin10, HIGH);
  
  delay(TIME_2);
  
  digitalWrite(pin10, LOW); //HIGH=ligado (5v)   -   LOW=desligada (0v)
  digitalWrite(pin10, HIGH);
  digitalWrite(pin10, LOW);
  delay(TIME_2);
}
