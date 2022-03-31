namespace UnitTests;

public class PluginTestsFixture
{
    public string DefaultText =>
        "In 1991, while studying computer science at University of Helsinki, Linus Torvalds began a project that later became the Linux kernel. He wrote the program specifically for the hardware he was using and independent of an operating system because he wanted to use the functions of his new PC with an 80386 processor. Development was done on MINIX using the GNU C Compiler.";

    public string ExpectedTextIn40Character => "In 1991, while studying computer science\r\n" +
                                               "at University of Helsinki, Linus\r\n" +
                                               "Torvalds began a project that later\r\n" +
                                               "became the Linux kernel. He wrote the\r\n" +
                                               "program specifically for the hardware he\r\n" +
                                               "was using and independent of an\r\n" +
                                               "operating system because he wanted to\r\n" +
                                               "use the functions of his new PC with an\r\n" +
                                               "80386 processor. Development was done on\r\n" +
                                               "MINIX using the GNU C Compiler.\r\n";


}