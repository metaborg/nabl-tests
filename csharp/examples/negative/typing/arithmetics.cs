namespace negative {
	namespace arithmetics {
	  
	  class Arithmetics {
	    int    i;
	    bool   b;
	    string s;
	    
	    void m() {
	    
	      s = "s"  + true;
	      s = true + "s";
	      
	      i = true + true;
	      i = 1    + true;
	      i = true + 1;
	      i = true - true;
	      i = 1    - true;
	      i = true - 1;
	      i = true * true;
	      i = 1    * true;
	      i = true * 1;
	      i = true / true;
	      i = 1    / true;
	      i = true / 1;
	      
	      b = true <  true;
	      b = 1    <  true;
	      b = true <  1;
	      b = "s"  <  true;
	      b = true <  "s";
	      b = true <= true;
	      b = 1    <= true;
	      b = true <= 1;
	      b = "s"  <= true;
	      b = true <= "s";
	      b = true >  true;
	      b = 1    >  true;
	      b = true >  1;
	      b = "s"  >  true;
	      b = true >  "s";
	      b = true >= true;
	      b = 1    >= true;
	      b = true >= 1;
	      b = "s"  >= true;
	      b = true >= "s";
	      b = 1    == true;
	      b = true == 1;
	      b = "s"  == true;
	      b = true == "s";
	    }
	  }
	}
}
