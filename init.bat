SET CLASSPATH=.;C:\Tools\antlr\antlr-4.9.2-complete.jar;%CLASSPATH%
doskey antlr4=java -jar C:\Tools\antlr\antlr-4.9.2-complete.jar $*
doskey grun=java org.antlr.v4.gui.TestRig $*


grun Hello prog tests\test1.txt -gui &