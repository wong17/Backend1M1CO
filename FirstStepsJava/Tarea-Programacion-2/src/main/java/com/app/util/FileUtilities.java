/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.app.util;

import com.app.model.Person;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.nio.file.Files;
import java.nio.file.LinkOption;
import java.nio.file.Path;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.stream.Collectors;

/**
 *
 * @author Wong
 */
public class FileUtilities {

    /**
     *
     */
    private FileUtilities() {
    }

    /**
     * This method is in charge to verify whether the indicate path exists or
     * not
     *
     * @param filePath to verify whether exists or not
     * @return
     */
    public static boolean verifyPath(Path filePath) {
        return Files.exists(filePath, new LinkOption[]{LinkOption.NOFOLLOW_LINKS});
    }

    /**
     * This method creates a new file and writes within the PORT
     *
     * @param filePath
     */
    public static void createFile(Path filePath) {
        try {
            boolean directoryExists = FileUtilities.verifyPath(filePath.getParent());
            if (!directoryExists) {
                Files.createDirectory(filePath.getParent());
            }
            Files.createFile(filePath);
        } catch (IOException ex) {
            Logger.getLogger(FileUtilities.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    /**
     *
     * @return
     */
    public static List<String> getContentAsList(Path filePath) {
        if (verifyPath(filePath) && filePath.toFile().length() > 0) {
            try {
                return Files.lines(filePath).collect(Collectors.toList());
            } catch (IOException ex) {
                Logger.getLogger(FileUtilities.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
        return Collections.emptyList();
    }

    /**
     *
     */
    private static void createOrLoadFile(Path filePath) {
        if (!FileUtilities.verifyPath(filePath)) {
            FileUtilities.createFile(filePath);
        }
    }

    /**
     *
     * @return
     */
    public static List<Person> getAll(Path filePath) {
        List<Person> people = new ArrayList<>();
        createOrLoadFile(filePath);
        if (filePath.toFile().length() > 0) {
            try (ObjectInputStream input
                    = new ObjectInputStream(new FileInputStream(filePath.toFile()))) {
                people = (List<Person>) input.readObject();
                return people;
            } catch (IOException | ClassNotFoundException ex) {
                return people;
            }
        }
        return people;
    }

    /**
     *
     * @param people
     */
    public static void saveAll(List<Person> people, Path filePath) {
        try {
            Files.deleteIfExists(filePath);
            FileUtilities.createFile(filePath);
            try (ObjectOutputStream output = new ObjectOutputStream(
                    new FileOutputStream(filePath.toFile()))) {
                output.writeObject(people);
            }
        } catch (IOException ex) {
            Logger.getLogger(FileUtilities.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}
