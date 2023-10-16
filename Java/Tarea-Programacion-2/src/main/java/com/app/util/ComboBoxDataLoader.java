/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.app.util;

import com.app.enums.ComboBoxFilePaths;
import java.net.URI;
import java.net.URISyntaxException;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Wong
 */
public class ComboBoxDataLoader {

    /**
     *
     */
    private static final List<String> departments;

    /**
     *
     */
    private static final Map<Integer, String[]> municipalities;

    /**
     *
     */
    static {
        departments = new ArrayList<>();
        municipalities = new HashMap<>();
        Path path = null;
        try {
            path = Paths.get(ComboBoxDataLoader.class.getResource(ComboBoxFilePaths.DEPARTMENTS.getValue()).toURI());
        } catch (URISyntaxException ex) {
            Logger.getLogger(ComboBoxDataLoader.class.getName()).log(Level.SEVERE, null, ex);
        }
        departments.addAll(FileUtilities.getContentAsList(path));
        municipalities.putAll(loadMunicipalities());
    }

    /**
     *
     */
    private ComboBoxDataLoader() {

    }

    /**
     *
     * @param name
     * @return
     */
    public static int getDepartmentIdByName(String name) {
        if (!name.isBlank()) {
            return departments.indexOf(name);
        }
        return -1;
    }

    /**
     *
     * @param name
     * @return
     */
    public static int getMunicipalityIdByName(int departmentId, String name) {
        if (!name.isBlank()) {
            return Arrays.binarySearch(municipalities.get(departmentId), 0,
                    municipalities.get(departmentId).length, name);
        }
        return -1;
    }

    /**
     *
     * @return
     */
    public static List<String> getDepartments() {
        if (!departments.isEmpty()) {
            return departments;
        }
        return Collections.emptyList();
    }

    /**
     *
     * @return
     */
    public static Map<Integer, String[]> getMunicipalities() {
        if (!municipalities.isEmpty()) {
            return municipalities;
        }
        return Collections.emptyMap();
    }

    /**
     *
     * @param departmentId
     * @param municipalityName
     * @return
     */
    public static String getMunicipalityById(int departmentId, int municipalityId) {
        return getMunicipalities().get(departmentId)[municipalityId];
    }

    /**
     *
     * @return
     */
    private static Map<Integer, String[]> loadMunicipalities() {
        Map<Integer, String[]> map = new HashMap<>();
        int index = 1;
        String arrayContent[];
        for (ComboBoxFilePaths path : ComboBoxFilePaths.values()) {
            if (path != ComboBoxFilePaths.DEPARTMENTS) {
                Path p = null;
                try {
                    p = getPath(path.getValue());
                } catch (URISyntaxException ex) {
                    Logger.getLogger(ComboBoxDataLoader.class.getName()).log(Level.SEVERE, null, ex);
                }
                List<String> content = FileUtilities.getContentAsList(p);
                arrayContent = new String[content.size()];
                arrayContent = content.toArray(arrayContent);
                map.put(index, arrayContent);
                index++;
            }
        }
        return map;
    }

    /**
     *
     * @param filePath
     * @return
     * @throws URISyntaxException
     */
    private static Path getPath(String filePath) throws URISyntaxException {
        URI uri = ComboBoxDataLoader.class.getResource(filePath).toURI();
        String mainPath = Paths.get(uri).toString();
        Path path = Paths.get(mainPath);
        return path;
    }
}
