lexer grammar XMLLexer;

OPEN  : '<'     -> pushMode(INSIDE) ;
COMMENT : '<!--' .*? '-->'    -> skip ;
EntityRef : '&' [a-z]+ ';'  ;
TEXT  : ~('<'|'&')+ ;

mode INSIDE;

CLOSE : '>' ;
SLASH_CLOSE : '/>'  ;
EQUALS  : '=' ;
STRING  : '"' .*? '"' ;
SlashName : '/' Name ;
Name  : ALPHA (ALPHA|DIGIT)*  ;
S     : [ \t\r\n] -> skip ;

fragment
ALPHA : [a-zA-Z] ;

fragment
DIGIT : [0-9] ;