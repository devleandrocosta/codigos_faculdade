class Data
{
    private int dia {get; set;}
    private int mes {get; set;}
    private int ano {get; set;}
    public Data(int dia, int mes, int ano){
        this.dia = dia;
        this.mes = mes;
        this.ano = ano; 
    }
    public Data Somar(Data data, int dias)
    {
        Data dataReturn = new Data(data.dia, data.mes, data.ano);
        data.dia += dias;
        if (data.dia > 31)
        {
            data.dia = (data.dia - 31);
            if (data.mes < 12)
            {
                dataReturn.mes++;
            }
            else if (data.mes == 12)
            {
                dataReturn.mes = 1;
                dataReturn.ano++;
            }
        }
        return dataReturn;
    }
    public Data Comparar(Data data1, Data data2)
    {
        if (data1.dia != data2.dia && data1.mes != data2.mes && data1.ano != data2.ano)
        {
            if (data1.ano != data2.ano)
            {
                if (data1.ano > data2.ano)
                {
                    return data1;
                }
                else
                {
                    return data2;
                }
            }
            else if(data1.mes != data2.mes){
                if (data1.mes > data2.mes)
                {
                    return data1;
                }
                else
                {
                    return data2;
                }
            }
            else if(data1.dia != data2.dia){
                if (data1.dia > data2.dia)
                {
                    return data1;
                }
                else
                {
                    return data2;
                }
            }
            else{
                Console.WriteLine("ERRO!");
                return data1;
            }
        }
        else{
            Console.WriteLine("DATAS IGUAIS");
            return data1;
        }

    }
    // public int Diferença(Data data1, Data data2){}
    public void View(Data data){
        Console.WriteLine(data.dia+"/"+data.mes+"/"+data.ano);
    }
}