package _5_CSharpExams;

import javax.xml.bind.annotation.XmlElementDecl;
import java.io.PrintStream;
import java.text.DecimalFormat;
import java.util.Arrays;
import java.util.DoubleSummaryStatistics;
import java.util.Scanner;

public class _04_FunWithMatrices {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double startN =Double.parseDouble(sc.nextLine());
        double step= Double.parseDouble(sc.nextLine());
        String numbersOfOperations = sc.nextLine();

        DecimalFormat df = new DecimalFormat("###.###");
        DecimalFormat df2 = new DecimalFormat("0.#");
        double[][] matrix = new double[4][4];
        startN = makesTheMatrix(startN, step, matrix,df);
        while(!numbersOfOperations.equals("Game Over!")) {
            //makes the matrix
            String[] operations = numbersOfOperations.split(" ");
            int operatRow = Integer.parseInt(operations[0]);
            int operatCol = Integer.parseInt(operations[1]);
            String command = operations[2];
            double numb = Double.parseDouble(operations[3]);

            changeInTheMatrix(operatRow,operatCol,command,numb,matrix);

            numbersOfOperations=sc.nextLine();
        }
        double rowSums =0;
        int rowIndex = 0;
        double colSums =0;
        double maxRowSum = Double.NEGATIVE_INFINITY;
        double maxColSum = Double.NEGATIVE_INFINITY;
        int rowP=0;
        int colP = 0;

        for (int i = 0; i < 4; i++) {
            rowSums=matrix[i][0]+matrix[i][1]+matrix[i][2]+matrix[i][3];
            colSums=matrix[0][i] +matrix[1][i] +matrix[2][i]+matrix[3][i];
            if(rowSums>maxRowSum){
                maxRowSum=rowSums;
                rowP=i;
            }
            if(colSums>maxColSum){
                maxColSum=colSums;
                colP=i;
            }
        }
        double matrixLeftDiagonal = matrix[0][0] +matrix[1][1]+matrix[2][2]+matrix[3][3];
        double matrixRightDiagonal = matrix[0][3]+matrix[1][2]+matrix[2][1]+matrix[3][0];


        if(maxRowSum>=maxColSum && maxRowSum>=matrixLeftDiagonal && maxRowSum>=matrixRightDiagonal){
            System.out.printf("ROW[%d] = %.2f", rowP, maxRowSum);
        }else if(maxColSum>maxRowSum && maxColSum>=matrixLeftDiagonal && maxColSum >=matrixRightDiagonal){
            System.out.printf("COLUMN[%d] = %.2f", colP, maxColSum);
        }else if(matrixLeftDiagonal>=matrixRightDiagonal && matrixLeftDiagonal>maxColSum && matrixLeftDiagonal>maxRowSum){
            System.out.printf("LEFT-DIAGONAL = %.2f", matrixLeftDiagonal);
        }else {
            System.out.printf("RIGHT-DIAGONAL = %.2f", matrixRightDiagonal);
        }


    }
    //                  aDouble= Double.parseDouble(df.format(aDouble));
//                  System.out.print(aDouble+" ");
    private static double makesTheMatrix(double startN, double step, double[][] matrix,DecimalFormat df) {
        for (int i = 0; i < 4; i++) {
            matrix[i] = new double[4];
            for (int j = 0; j < 4; j++) {

                matrix[i][j] = startN;
                startN += step;
            }
        }
        return startN;
    }
    private static void changeInTheMatrix(int operatRow, int operatCol, String command, double numb, double[][] matrix) {
        if(command.equals("multiply")){
            matrix[operatRow][operatCol]=matrix[operatRow][operatCol]*numb;
        }else if(command.equals("sum")){
            matrix[operatRow][operatCol]=matrix[operatRow][operatCol]+numb;
        }else if(command.equals("power")){
            matrix[operatRow][operatCol]= Math.pow(matrix[operatRow][operatCol], numb);
        }
    }

}