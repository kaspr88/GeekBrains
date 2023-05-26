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

    @Override
    public String toString() {
        return "Notebook{" +
                "Ram=" + Ram +
                ", Rom=" + Rom +
                ", OS='" + OS + '\'' +
                ", Color='" + Color + '\'' +
                '}';
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj instanceof Notebook notebook)) {
            return false;
        }
        return Ram==notebook.Ram && Rom == notebook.Rom &&
                OS.equals(notebook.OS)  && Color.equals(notebook.Color);
    }

    @Override
    public int hashCode() {
        return Ram + 7 * Rom + 11 * OS.hashCode() + 14 * Color.hashCode();
    }
}
