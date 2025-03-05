// C++ code
//

int led_red=10, led_yellow=11, led_green=12;
int time=7000; 

void setup() {
  pinMode(led_red, OUTPUT); //OUTPUT=saida    -   INPUT=entrada
  pinMode(led_yellow, OUTPUT); 
  pinMode(led_green, OUTPUT); 
}

void changeColor(int led_lit, int letd_off1, int led_off2){
  digitalWrite(led_lit, HIGH);
  digitalWrite(letd_off1, LOW);
  digitalWrite(led_off2, LOW);
  delay(time);
}

void loop() {
  changeColor(led_green, led_yellow, led_red);
  changeColor(led_yellow, led_red, led_green);
  changeColor(led_red, led_yellow, led_green);
}
