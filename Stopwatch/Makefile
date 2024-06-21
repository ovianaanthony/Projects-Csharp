# Makefile for use with mono with multiple compilation targets

MAIN_CLASS = test_Timer.cs
PARTIAL_CLASSES = Timer.cs
OPT = -optimize+

all:
	$(CSHARP) $(OPT) $(MAIN_CLASS) $(PARTIAL_CLASSES)

clean:
	rm *.exe
