// Define a grammar called Hello
grammar Hello;

/* the grammer name and file name must match */

// always put EOF
prog: (decl | expr)+ EOF
  ;

decl: ID ':' INT_TYPE '=' NUM
  ;

expr: expr '*' expr
  | expr '+' expr
  | ID
  | NUM
  ;

/* TOKENS */

ID : [a-z][a-zA-Z0-9_]*;
NUM : '0' | '-'?[1-9][0-9]*;
INT_TYPE : 'INT';
COMMENT : '--' ~[\r\n]* ->skip;
WS : [ \t\r\n]+ ->skip;