grammar Rows;

@parser::members {
  int col;
  public RowsParser(TokenStream input, int col) {
    this(input);
    this.col = col;
  }
}

file: (row NEWLINE)+ ;

row
locals [int i=0]
  :(  STUFF
      {
        $i++;
        if ( $i == col) System.out.println($STUFF.text);
      }
    )+
  ;

TAB : '\t' -> skip ;
NEWLINE : '\r'? '\n'  ;
STUFF:  ~[\t\r\n]+  ;