// C++ code
//
#define an5 A5
#define p1 4
#define p2 5
#define p3 6
#define p4 7
#define p5 8
#define p6 9

void setup() {
  pinMode(an5, INPUT);
  //Serial.begin(9600);

  pinMode(p1, OUTPUT);
  pinMode(p2, OUTPUT);
  pinMode(p3, OUTPUT);
  pinMode(p4, OUTPUT);
  pinMode(p5, OUTPUT);
  pinMode(p6, OUTPUT);
}

void loop() {
  //Serial.println(analogRead(an5));
  //delay(100);

  long tensao = map(analogRead(an5), 0, 1023, 0, 6);

  if(tensao > 0 ) {
    digitalWrite(p1, HIGH);
  }
  else{
     digitalWrite(p1, LOW);
  }

  if(tensao > 1) {
    digitalWrite(p2, HIGH);
  }else{
     digitalWrite(p2, LOW);
  }
  
  if(tensao > 2) {
    digitalWrite(p3, HIGH);
  }else{
     digitalWrite(p3, LOW);
  }

  if(tensao > 3) {
    digitalWrite(p4, HIGH);
  }
  else{
     digitalWrite(p4, LOW);
  }

  if(tensao > 4) {
    digitalWrite(p5, HIGH);
  }
  else{
     digitalWrite(p5, LOW);
  }

  if(tensao > 5) {
    digitalWrite(p6, HIGH);
  }else{
     digitalWrite(p6, LOW);
  }
}
