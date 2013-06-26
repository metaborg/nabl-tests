namespace arithmetics {
  
  class Arithmetics {
    int i;
    bool b;
    string s;
    
    void m() {
    
      s = "s" + "s";
      s = 1   + "s";
      s = "s" + 1;
      
      i = 1 + 1;
      i = 1 - 1;
      i = 1 * 1;
      i = 1 / 1;
    
      b = 1 <  1;
      b = 1 <= 1;
      b = 1 >= 1;
      b = 1 >  1;
      
      b = "s" <  "s";
      b = "s" <= "s";
      b = "s" >= "s";
      b = "s" >  "s";
      
      b = 1    == 1;  
      b = "s"  == "s";  
      b = "s"  == 1;
      b = 1    == "s";
      b = true == false;
    }
  }
}
