int LED = 13;
String data = "";
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(LED, OUTPUT);
}


void loop() {
 
  data = Serial.readStringUntil('\n');
  if(data == "HPin")
  {
    digitalWrite(LED, HIGH);Serial.println(data); 
  }
  else if(data == "LPin")
  {
      digitalWrite(LED,LOW); Serial.println(data);  
  }
    
}

