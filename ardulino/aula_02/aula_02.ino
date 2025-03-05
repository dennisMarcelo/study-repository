// C++ code
//

void setup() {
  pinMode(13, OUTPUT); //OUTPUT=saida    -   INPUT=entrada
}

void loop() {
  digitalWrite(13, HIGH); //HIGH=ligado (5v)   -   LOW=desligada (0v)
  delay(500);
  digitalWrite(13, LOW); //HIGH=ligado (5v)   -   LOW=desligada (0v)
  delay(500);
}
