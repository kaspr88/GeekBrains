import javax.swing.plaf.basic.BasicToolBarSeparatorUI;
import java.util.Map;

public class Notebook {

    private int Ram;
    private int Rom;
    private String OS;
    private String Color;


    public Notebook(int ram, int rom, String OS, String color) {
        Ram = ram;
        Rom = rom;
        this.OS = OS;
        Color = color;
    }

   @Override
    public String toString() {
        return "Notebook{" +
                "Ram=" + Ram +
                ", Rom=" + Rom +
                ", OS='" + OS + '\'' +
                ", Color='" + Color + '\'' +
                '}';
    }

    public int getRam() {
        return Ram;
    }

    public void setRam(int ram) {
        Ram = ram;
    }

    public int getRom() {
        return Rom;
    }

    public void setRom(int rom) {
        Rom = rom;
    }

    public String getOS() {
        return OS;
    }

    public void setOS(String OS) {
        this.OS = OS;
    }

    public String getColor() {
        return Color;
    }

    public void setColor(String color) {
        Color = color;
    }
}
