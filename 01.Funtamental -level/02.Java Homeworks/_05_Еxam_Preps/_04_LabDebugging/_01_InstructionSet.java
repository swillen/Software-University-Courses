package _04_LabDebugging;

import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by veronica on 25.01.15.
 */
public class _01_InstructionSet {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String opCode = input.nextLine();
        String[] codeArgs = opCode.split(" ");

        while (!codeArgs.equals("END")) {


            long result = 0;
            switch (codeArgs[0]) {
                case "INC": {
                    long operandOne = Long.parseLong(codeArgs[1]);
                    result =++operandOne;
                    break;
                }
                case "DEC": {
                    long operandOne = Long.parseLong(codeArgs[1]);
                    result = --operandOne;
                    break;
                }
                case "ADD": {
                    long operandOne  = Long.parseLong(codeArgs[1]);
                    long operandTwo = Long.parseLong(codeArgs[2]);
                    result = operandOne + operandTwo;
                    break;
                }
                case "MLA": {
                    long operandOne  = Long.parseLong(codeArgs[1]);
                    long operandTwo = Long.parseLong(codeArgs[2]);
                    result = (long)(operandOne * operandTwo);
                    break;
                }
                default:
                    break;

            }

            System.out.println(result);
            opCode=input.nextLine();
            if(opCode.equals("END")){
                break;
            }
            codeArgs=opCode.split(" ");
        }
    }
}
