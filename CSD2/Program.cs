int Yes_pass = 0, No_pass = 0, i,j=0,k=0;
double[] score = { 75.0, 54.0, 92.0, 60.0, 43.0 };
double[] yes_score = new double[5];
double[] No_score = new double[5];
double Y_average=0,N_average=0;

for (i = 0; i <= 4; i++)
{
    if (score[i] >= 60)
    {
        Y_average += score[i];
        yes_score[Yes_pass] = score[i];
        Yes_pass += 1;
    }
    else
    {
        N_average += score[i];
        No_score[No_pass] = score[i];
        No_pass += 1;
    }
}
Y_average /= Yes_pass;
N_average /= No_pass;

for (i = 0; i <=4; i++)
{
    if (score[i] > Y_average)
    {
        j += 1;
    }
    else
    {
        k += 1;
    }
}

Console.WriteLine("已通過 人數：" + Yes_pass + ", 平均：" + Y_average.ToString("0.00"));
Console.WriteLine("未通過 人數：" + No_pass + ", 平均：" + N_average.ToString("0.00"));
Console.WriteLine("高於平均人數：" + j + ", 低於平均人數：" + k);
Console.ReadLine();