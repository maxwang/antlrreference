SET CLASSPATH=.;C:\Tools\antlr\antlr-4.9.2-complete.jar;%CLASSPATH%
doskey antlr4=java -jar C:\Tools\antlr\antlr-4.9.2-complete.jar $*
doskey grun=java org.antlr.v4.gui.TestRig $*

# run test with GUI
#grun Hello prog tests\test1.txt -gui &

# generate csharp code with visitor
# antlr4 -no-listener -visitor -Dlanguage=CSharp LabeledExpr.g4