# Makefile for use with mono with multiple compilation targets

MAIN_CLASS = test_Edit.cs
PARTIAL_CLASSES = Edit.cs
OPT = -optimize+

all:
	$(CSHARP) $(OPT) $(MAIN_CLASS) $(PARTIAL_CLASSES)

clean:
	rm *.exe
