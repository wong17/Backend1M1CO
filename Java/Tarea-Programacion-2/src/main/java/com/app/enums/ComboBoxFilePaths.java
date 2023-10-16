/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.app.enums;

/**
 *
 * @author Wong
 */
public enum ComboBoxFilePaths {

    /**
     *
     */
    DEPARTMENTS("/com/app/files/Departments.txt"),
    /**
     *
     */
    BOACO("/com/app/files/BoacoMunicipalities.txt"),
    /**
     *
     */
    CARAZO("/com/app/files/CarazoMunicipalities.txt"),
    /**
     *
     */
    CHINANDEGA("/com/app/files/ChinandegaMunicipalities.txt"),
    /**
     *
     */
    CHONTALES("/com/app/files/ChontalesMunicipalities.txt"),
    /**
     *
     */
    COSTA_CARIBE_NORTE("/com/app/files/CostaCaribeNorteMunicipalities.txt"),
    /**
     *
     */
    COSTA_CARIBE_SUR("/com/app/files/CostaCaribeSurMunicipalities.txt"),
    /**
     *
     */
    ESTELI("/com/app/files/EsteliMunicipalities.txt"),
    /**
     *
     */
    GRANADA("/com/app/files/GranadaMunicipalities.txt"),
    /**
     *
     */
    JINOTEGA("/com/app/files/JinotegaMunicipalities.txt"),
    /**
     *
     */
    LEON("/com/app/files/LeonMunicipalities.txt"),
    /**
     *
     */
    MADRIZ("/com/app/files/MadrizMunicipalities.txt"),
    /**
     *
     */
    MANAGUA("/com/app/files/ManaguaMunicipalities.txt"),
    /**
     *
     */
    MASAYA("/com/app/files/MasayaMunicipalities.txt"),
    /**
     *
     */
    MATAGALPA("/com/app/files/MatagalpaMunicipalities.txt"),
    /**
     *
     */
    NUEVA_SEGOVIA("/com/app/files/NuevaSegoviaMunicipalities.txt"),
    /**
     *
     */
    RIO_SAN_JUAN("/com/app/files/RioSanJuanMunicipalities.txt"),
    /**
     *
     */
    RIVAS("/com/app/files/RivasMunicipalities.txt");

    /**
     *
     */
    private final String VALUE;

    /**
     *
     */
    private ComboBoxFilePaths(String value) {
        this.VALUE = value;
    }

    /**
     *
     * @return
     */
    public String getValue() {
        return VALUE;
    }

}
