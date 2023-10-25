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
public enum DataFilePaths {
    
    /**
     * 
     */
    ID_FILE_PATH("data/idFile.txt"),
    /**
     * 
     */
    DATA_FILE_PATH("data/PeopleData.bin");
    
    /**
     * 
     */
    private final String VALUE;
    
    /**
     * 
     * @param value 
     */
    private DataFilePaths(String value) {
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
