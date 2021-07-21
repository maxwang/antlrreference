grammar LabeledExpr;

prog: stat+ ;

stat: expr NEWLINE            # printExpr
    | ID '='  expr NEWLINE    # assign
    | NEWLINE                 # blank
    ;

expr: expr op=('*'|'/') expr  # MulDiv
    | expr op=('+'|'-') expr  # AddSub
    | INT                     # INT
    | ID                      # id
    | '(' expr ')'            # parens
    ;

MUL : '*' ;
DIV : '/' ;
ADD : '+' ;
SUB : '-' ;
ID  : [a-zA-Z]+ ;
INT : [0-9]+  ;
NEWLINE: '\r'? '\n' ;
WS : [ \t\r\n]+ -> skip ;